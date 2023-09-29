using Microsoft.AspNetCore.Mvc;
using TaskManager.ApiGateway.DTOs.Requests;
using TaskManager.ApiGateway.Interfaces.Services;

namespace TaskManager.ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthenticateRequestDto request)
        {
            await _authService.Authenticate(request);
            return null;
        }
    }
}
