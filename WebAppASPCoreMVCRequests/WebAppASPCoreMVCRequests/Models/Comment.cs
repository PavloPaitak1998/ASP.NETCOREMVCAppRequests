
namespace WebAppASPCoreMVCRequests.Models
{
    public sealed class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int Likes { get; set; }
        public string CreatedAt { get; set; }
    }
}
