namespace UserManagement.Domain.Models
{
    public class Tasks
    {
        public int Id { get; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public TaskStatusEnum Status { get; set; }
        public int UserId { get; set; }
    }

    public enum TaskStatusEnum
    {
        Todo,
        Done,
        Delayed
    }
}