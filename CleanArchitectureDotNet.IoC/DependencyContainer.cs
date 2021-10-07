using CleanArchitectureDotNet.Presenters;
using CleanArchitectureDotNet.RepositoryEFCore;
using CleanArchitectureDotNet.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDotNet.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUsesCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
