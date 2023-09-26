using Microsoft.Extensions.DependencyInjection;

namespace User.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddServices();

            return services;
        }
    }
}
