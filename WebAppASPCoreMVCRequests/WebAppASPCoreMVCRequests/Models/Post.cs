using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppASPCoreMVCRequests.Models
{
    public sealed class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int Likes { get; set; }
        public string CreatedAt { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
