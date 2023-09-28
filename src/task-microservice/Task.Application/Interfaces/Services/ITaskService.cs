using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Domain.Models;

namespace Application.Interfaces.Services
{
    public interface ITaskService
    {
        Task<ApiResponse<bool>> CreateTask(CreateTaskRequestDto taskDto);
        Task<ApiResponse<TaskResponseDto>> GetTaskById(long taskId);
        Task<ApiResponse<TaskListResponseDto>> GetTaskByUserId(long userId);
    }
}
