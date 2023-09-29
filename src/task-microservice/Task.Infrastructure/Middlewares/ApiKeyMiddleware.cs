using Infrastructure.Configurations;
using Microsoft.Extensions.Options;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _secretKey;
        private const string APIKEYNAME = "task-secret-key";

        public ApiKeyMiddleware(RequestDelegate next, IOptions<ApiSettings> apiSettings)
        {
            _next = next;
            _secretKey = apiSettings.Value.SecretKey;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.Keys.Contains(APIKEYNAME) ||
                context.Request.Headers[APIKEYNAME].FirstOrDefault() != _secretKey)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("API Key is missing or invalid.");
                return;
            }

            await _next.Invoke(context);
        }
    }
}
