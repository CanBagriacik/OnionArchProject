using Microsoft.Extensions.DependencyInjection;
using OnionArch.APPLICATION.Managers;
using OnionArch.InnerInfrastructure.ManagerConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.InnerInfrastructure.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IAppUserRoleManager, AppUserRoleManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppUserProfileManager, AppUserProfileManager>();


        }
    }
}
