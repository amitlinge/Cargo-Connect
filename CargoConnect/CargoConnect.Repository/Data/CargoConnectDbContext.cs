using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CargoConnect.Repository.Data
{
    public class CargoConnectDbContext : DbContext
    {
        public CargoConnectDbContext(DbContextOptions<CargoConnectDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> users { get; set; }
        public DbSet<DriverEntity> drivers{ get; set; }
    }
}
