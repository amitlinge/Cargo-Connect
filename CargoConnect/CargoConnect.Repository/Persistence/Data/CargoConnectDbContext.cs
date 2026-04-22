using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CargoConnect.Infrastructure.Persistence.Data
{
    public class CargoConnectDbContext : DbContext
    {
        public CargoConnectDbContext(DbContextOptions<CargoConnectDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<DriverEntity>().HasIndex(d => d.Email).IsUnique();
            modelBuilder.Entity<DriverEntity>().HasIndex(d => d.LicenseNumber).IsUnique();
            modelBuilder.Entity<VehicalEntity>().HasIndex(d => d.NumberPlate).IsUnique();
        }
        public DbSet<UserEntity> users { get; set; }
        public DbSet<DriverEntity> drivers{ get; set; }
        public DbSet<VehicalEntity> vehicals { get; set; }
        public DbSet<TrackingEntity> trackings { get; set; }
        public DbSet<PaymentEntity> payments { get; set; }
        public DbSet<BookingEntity> bookings { get; set; }
        public DbSet<TransactionEntity> transactions { get; set; }
    }
}
