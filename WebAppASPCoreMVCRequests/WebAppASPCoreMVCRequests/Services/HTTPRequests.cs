using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAppASPCoreMVCRequests.Services
{
    public static class HTTPRequests
    {
        private static readonly HttpClient client = new HttpClient();

        public static List<User> GetUsers()
        {
            string page = "https://5b128555d50a5c0014ef1204.mockapi.io/users";

            Task<string> t = GetData(page);
            t.Wait();

            return JsonConvert.DeserializeObject<List<User>>(t.Result);
        }

        public static List<Post> GetPosts()
        {
            string page = "https://5b128555d50a5c0014ef1204.mockapi.io/posts";

            Task<string> t = GetData(page);
            t.Wait();

            return JsonConvert.DeserializeObject<List<Post>>(t.Result);
        }

        public static List<Comment> GetComments()
        {
            string page = "https://5b128555d50a5c0014ef1204.mockapi.io/comments";

            Task<string> t = GetData(page);
            t.Wait();

            return JsonConvert.DeserializeObject<List<Comment>>(t.Result);
        }

        public static List<Todo> GetTodos()
        {
            string page = "https://5b128555d50a5c0014ef1204.mockapi.io/todos";

            Task<string> t = GetData(page);
            t.Wait();

            return JsonConvert.DeserializeObject<List<Todo>>(t.Result);
        }

        static async Task<string> GetData(string page)
        {
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                return await content.ReadAsStringAsync();
            }
        }
    }
}
