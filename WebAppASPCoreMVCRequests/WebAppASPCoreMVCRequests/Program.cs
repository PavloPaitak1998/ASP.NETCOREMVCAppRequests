using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebAppASPCoreMVCRequests.Data;
using WebAppASPCoreMVCRequests.Services;

namespace WebAppASPCoreMVCRequests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var dataSource = services.GetRequiredService<DataSource>();
                    dataSource.Comments = HTTPRequests.GetComments();

                    dataSource.Posts = LinqRequests.GetPostsEntity(HTTPRequests.GetPosts()
                        , dataSource.Comments);

                    dataSource.Todos = HTTPRequests.GetTodos();

                    dataSource.Users = LinqRequests.GetUsersEntity(HTTPRequests.GetUsers()
                        , dataSource.Posts, dataSource.Todos);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while creating data source.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
