using System.Collections.Generic;

namespace WebAppASPCoreMVCRequests.Models
{
    public sealed class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string CreatedAt { get; set; }

        public List<Post> Posts { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
