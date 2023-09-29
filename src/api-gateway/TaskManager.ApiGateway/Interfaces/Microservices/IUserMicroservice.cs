using Microsoft.AspNetCore.Mvc;
using Refit;
using TaskManager.ApiGateway.DTOs.Requests;

namespace TaskManager.ApiGateway.Interfaces
{
    public interface IUserMicroservice
    {
        [Post("/users/authenticate")]
        Task<string> Authenticate([FromBody]AuthenticateRequestDto request);
    }
}
