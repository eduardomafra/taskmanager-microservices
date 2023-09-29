using TaskManager.ApiGateway.DTOs.Requests;
using TaskManager.ApiGateway.Interfaces;
using TaskManager.ApiGateway.Interfaces.Services;

namespace TaskManager.ApiGateway.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserMicroservice _userMicroservice;

        public AuthService(IUserMicroservice userMicroservice)
        {
            _userMicroservice = userMicroservice;
        }

        public async Task Authenticate(AuthenticateRequestDto request)
        {
            try
            {
                await _userMicroservice.Authenticate(request);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
