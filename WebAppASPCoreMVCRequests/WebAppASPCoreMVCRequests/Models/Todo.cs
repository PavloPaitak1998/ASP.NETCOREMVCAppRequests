
namespace WebAppASPCoreMVCRequests.Models
{
    public sealed class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
        public string CreatedAt { get; set; }
    }
}
