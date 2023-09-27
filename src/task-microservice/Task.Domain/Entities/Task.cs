using Task.Domain.Enums;

namespace Task.Domain.Entities
{
    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Conclusion { get; set; }
        public TaskStatusEnum Status { get; set; }
        public TaskPriorityEnum Priority { get; set; }
        public long UserId { get; set; }
        public IEnumerable<Subtask> Subtasks { get; set; }
    }
}
