using Microsoft.AspNetCore.Mvc;
using User.Application.DTOs.Requests;
using User.Application.Interfaces.Services;

namespace User.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        #region Properties

        private readonly IUserService _userService;

        #endregion

        #region Constructor

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Public Methods

        [HttpPost("[action]")]
        public async Task<IActionResult> Authenticate([FromBody] UserLoginRequestDto request)
        {
            var result = await _userService.AuthenticateAsync(request);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequestDto request)
        {
            var result = await _userService.RegisterAsync(request);
            return StatusCode(result.StatusCode, result);
        }

        #endregion
    }
}
