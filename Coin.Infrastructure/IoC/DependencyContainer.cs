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
            services.AddTransient<IEmailSender, EmailSender>();
            // services.AddScoped<IProductService, ProductService>();
            // services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}