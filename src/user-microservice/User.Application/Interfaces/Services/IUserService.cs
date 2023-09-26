using User.Application.DTOs.Requests;
using User.Application.DTOs.Responses;

namespace User.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<ApiResponse<string>> RegisterAsync(UserRegisterRequestDto userRegisterRequestDto);
    }
}
