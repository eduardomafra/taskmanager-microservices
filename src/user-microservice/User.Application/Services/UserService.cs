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

        public async Task<ApiResponse<string>> RegisterAsync(UserRegisterRequestDto userRegisterRequestDto)
        {
            try
            {
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterRequestDto.Password);
                var user = new Domain.Entities.User(userRegisterRequestDto.Username, passwordHash, userRegisterRequestDto.Email);

                await _repository.AddAsync(user);

                return new ApiResponse<string>(true, "Usuário registrado com sucesso", 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse<string>(true, "Ocorreu um erro na solicitação", 500);
            }
            
        }

        #endregion
    }
}
