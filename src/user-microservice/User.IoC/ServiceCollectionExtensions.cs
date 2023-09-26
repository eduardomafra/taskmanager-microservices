using Microsoft.Extensions.DependencyInjection;
using User.Application.Interfaces.Services;
using User.Application.Services;
using User.Domain.Interfaces.Repositories;
using User.Infrastructure.Repositories;

namespace User.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
