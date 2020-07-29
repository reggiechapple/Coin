using Coin.Application.Interfaces;
using Coin.Application.Services;
using Coin.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Coin.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IProductService, ProductService>();

            // CleanArchitecture.Infrastructure.Data.Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}