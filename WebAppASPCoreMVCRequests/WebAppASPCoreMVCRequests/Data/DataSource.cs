using System.Collections.Generic;
using WebAppASPCoreMVCRequests.Models;

namespace WebAppASPCoreMVCRequests.Data
{
    public class DataSource
    {
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
