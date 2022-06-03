using Demo.CleanArquitecture.Entities.Interfaces;
using Demo.CleanArquitecture.RepositoryEFCore.DataContext;
using Demo.CleanArquitecture.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.CleanArquitecture.RepositoryEFCore
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration
        )
        {
            services.AddDbContext<DataBaseContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DataBaseContext")
                )
            );  //  AddDbContext: Cada vez que me pidan, devuelvo el mismo contexto instanciado desde un inicio

            services.AddScoped<IProductRepository, ProductRepository>();  //  AddScoped: Cada vez que me pidan, devuelvo la misma instancia creada desde un inicio
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
