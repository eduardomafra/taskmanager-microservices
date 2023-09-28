using Application.DTOs.Requests;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        #region Properties

        private readonly ITaskService _taskService;

        #endregion

        #region Constructor

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        #endregion

        #region Public Methods

        [HttpGet("{taskId}")]
        public async Task<IActionResult> GetTaskById(long taskId)
        {
            var result = await _taskService.GetTaskById(taskId);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetTasksByUserId(long userId)
        {
            var result = await _taskService.GetTaskByUserId(userId);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTaskRequestDto task)
        {
            var result = await _taskService.CreateTask(task);
            return StatusCode(result.StatusCode, result);
        }

        #endregion
    }
}
