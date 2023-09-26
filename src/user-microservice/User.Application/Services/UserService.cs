using User.Application.DTOs.Requests;
using User.Application.DTOs.Responses;
using User.Application.Interfaces.Services;
using User.Domain.Interfaces.Repositories;

namespace User.Application.Services
{
    public class UserService : IUserService
    {
        #region Properties

        private readonly IUserRepository _repository;

        #endregion

        #region Constructor

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Public Methods

        public async Task<ApiResponse<bool>> AuthenticateAsync(UserLoginRequestDto loginRequest)
        {
            try
            {
                var user = await _repository.GetByUsername(loginRequest.Username);

                if (user == null)
                    return new ApiResponse<bool>(false, 401, false);

                if (!BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.PasswordHash))
                    return new ApiResponse<bool>(false, 401, false);

                return new ApiResponse<bool>(true, 200, true);
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>(false, 500, false, new List<string> { "Ocorreu um erro na solicitação" });
            }
        }

        public async Task<ApiResponse<string>> RegisterAsync(UserRegisterRequestDto userRegisterRequestDto)
        {
            try
            {
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterRequestDto.Password);
                var user = new Domain.Entities.User(userRegisterRequestDto.Username, passwordHash, userRegisterRequestDto.Email);

                await _repository.AddAsync(user);

                return new ApiResponse<string>(true, 200, "Usuário registrado com sucesso");
            }
            catch (Exception ex)
            {
                return new ApiResponse<string>(false, 500, null, new List<string> { "Ocorreu um erro na solicitação" });
            }
            
        }

        #endregion
    }
}
