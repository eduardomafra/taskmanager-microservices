using Domain.Enums;

namespace Application.DTOs.Requests
{
    public class CreateTaskRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatusEnum Status { get; set; }
        public TaskPriorityEnum Priority { get; set; }
        public long UserId { get; set; }
    }
}
