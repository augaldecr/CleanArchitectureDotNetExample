using CleanArchitectureDotNet.UseCases.CreateProduct;
using CleanArchitectureDotNet.UseCases.GetAllProducts;
using CleanArchitectureDotNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDotNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUsesCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

            return services;
        }
    }
}
