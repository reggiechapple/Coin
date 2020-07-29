using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coin.Data;
using Coin.Domain.Identity;
using Coin.Infrastructure.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Coin.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"),  
                    b => b.MigrationsAssembly("Coin.Data")));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.Stores.MaxLengthForKeys = 128)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Configure Identity options and password complexity here
            services.Configure<IdentityOptions>(options =>
            {
                // User settings
                options.User.RequireUniqueEmail = true;

                //    //// Password settings
                //    //options.Password.RequireDigit = true;
                //    //options.Password.RequiredLength = 8;
                //    //options.Password.RequireNonAlphanumeric = false;
                //    //options.Password.RequireUppercase = true;
                //    //options.Password.RequireLowercase = false;

                //    //// Lockout settings
                //    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                //    //options.Lockout.MaxFailedAccessAttempts = 10;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            DependencyContainer.RegisterServices(services);
            services.AddSession();
            services.AddControllersWithViews();
            services.AddSignalR(configure => configure.EnableDetailedErrors = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
