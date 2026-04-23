using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CargoConnect.Application.DependencyInjection
{
    public static class RegisterService
    {
        public static void AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            

            //user Service
            services.AddScoped<IUserService,UserService>();

            //Driver Service
            services.AddScoped<IDriverService, DriverService>();

            //transaction Service
            services.AddScoped<ITransactionService, TransactionService>();

            //Vehical Services
            services.AddScoped<IVehicalService, VehicalService>();

            //Booking Services
            services.AddScoped<IBookingService, BookingService>();

            //auth service
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
