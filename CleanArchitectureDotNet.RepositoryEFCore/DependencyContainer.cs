using CleanArchitectureDotNet.Entities.Interfaces;
using CleanArchitectureDotNet.RepositoryEFCore.DataContext;
using CleanArchitectureDotNet.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDotNet.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArchitectureDotNetDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CleanArchitectureDbContext")));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
