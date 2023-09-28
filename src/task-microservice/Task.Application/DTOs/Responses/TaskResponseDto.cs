using Domain.Enums;

namespace Application.DTOs.Responses
{
    public class TaskResponseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Conclusion { get; set; }
        public TaskStatusEnum Status { get; set; }
        public TaskPriorityEnum Priority { get; set; }
    }
}
