using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.Interfaces;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Application.Services;
using CargoConnect.Infrastructure.ExternalServices;
using CargoConnect.Infrastructure.Persistence.Data;
using CargoConnect.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CargoConnect.Infrastructure.DependencyInjection
{
    public static class RegisterServices
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CargoConnectDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //Mapping Service
            services.AddScoped<IMappingService, AutoMapperService>();

            //password hasher service
            services.AddScoped<PasswordHasher<string>>();

            //password service
            services.AddScoped<IPasswordService, PasswordService>();
        }
    }
}
