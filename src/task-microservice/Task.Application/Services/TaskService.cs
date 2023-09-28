using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.Interfaces.Services;
using Domain.Interfaces.Repositories;
using Domain.Models;
using Mapster;

namespace Application.Services
{
    public class TaskService : ITaskService
    {
        #region Properties

        private readonly ITaskRepository _taskRepository;

        #endregion

        #region Constructor

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        #endregion

        #region Public Methods

        public async Task<ApiResponse<TaskResponseDto>> GetTaskById(long taskId)
        {
            try
            {
                var task = await _taskRepository.GetByIdAsync(taskId);
                var taskDto = task.Adapt<TaskResponseDto>();
                return new ApiResponse<TaskResponseDto>(200, taskDto);
            }
            catch (Exception ex)
            {
                return new ApiResponse<TaskResponseDto>(500, new List<string>() { "Ocorreu um erro." });
            }            
        }

        public async Task<ApiResponse<TaskListResponseDto>> GetTaskByUserId(long userId)
        {
            try
            {
                var tasks = await _taskRepository.GetTaskByUserId(userId);
                var tasksDto = tasks.Adapt<List<TaskResponseDto>>();
                var taskListDto = new TaskListResponseDto() { Tasks = tasksDto };
                return new ApiResponse<TaskListResponseDto>(200, taskListDto);
            }
            catch (Exception ex)
            {
                return new ApiResponse<TaskListResponseDto>(500, new List<string>() { "Ocorreu um erro." });
            }
        }

        public async Task<ApiResponse<bool>> CreateTask(CreateTaskRequestDto taskDto)
        {
            try
            {
                var task = new Domain.Entities.Task()
                {
                    Name = taskDto.Name,
                    Description = taskDto.Description,
                    Status = taskDto.Status,
                    Priority = taskDto.Priority,
                    UserId = taskDto.UserId,
                    Created = DateTime.Now
                };

                await _taskRepository.AddAsync(task);
                return new ApiResponse<bool>(200, true);
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>(500, new List<string>() { "Ocorreu um erro." });
            }
        }

        #endregion

        #region Private Methods

        #endregion
    }
}
