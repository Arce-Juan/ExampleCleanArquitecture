using Demo.CleanArquitecture.UseCases.CreateProduct;
using Demo.CleanArquitecture.UseCases.GetAllProducts;
using Demo.CleanArquitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.CleanArquitecture.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();  //  AddTransient: Cada que me lo pindan, devuelvo una nueva instancia
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

            return services;
        }
    }
}
