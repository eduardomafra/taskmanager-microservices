using System.Text.Json.Serialization;

namespace TaskManager.ApiGateway.DTOs.Requests
{
    public class AuthenticateRequestDto
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
