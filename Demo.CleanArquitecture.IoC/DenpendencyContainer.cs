using Demo.CleanArquitecture.Presenters;
using Demo.CleanArquitecture.RepositoryEFCore;
using Demo.CleanArquitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.CleanArquitecture.IoC
{
    public static class DenpendencyContainer
    {
        public static IServiceCollection AddDemoCleanArquitectureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();

            return services;
        }
    }
}
