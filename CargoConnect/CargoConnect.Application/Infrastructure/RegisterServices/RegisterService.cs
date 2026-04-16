using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Repository.Data;
using CargoConnect.Repository.Repositories.Implementations;
using CargoConnect.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CargoConnect.Application.Infrastructure.RegisterServices
{
    public static class RegisterService
    {
        public static void AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<CargoConnectDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
        }
    }
}
