using TaskManager.ApiGateway.DTOs.Requests;

namespace TaskManager.ApiGateway.Interfaces.Services
{
    public interface IAuthService
    {
        Task Authenticate(AuthenticateRequestDto request);
    }
}
