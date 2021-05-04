using Microsoft.Extensions.DependencyInjection;
using Pos.Api.Application.Contracts.Services;
using Pos.Api.Application.Services;
using Pos.Api.DataAccess.Contracts.IRepositories;
using Pos.Api.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.CrossCutting
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepositories(services);
            AddRegisterServices(services);
            return services;

        }
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            //Se van a instanciar cuando se llamen.
            services.AddTransient<IProductService, ProductService>();
            return services;
        }
        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IExternalUserRepository, ExternalUserRepository>();
            return services;
        }
    }
}
