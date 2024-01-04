
using Microsoft.EntityFrameworkCore;
using TruckManagement.Models;
namespace TruckManagement.Data
{
    public class TruckManagementDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Delivery> Deliveries { get; set; } = default!;
        public DbSet<Status> Statuses { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TruckDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Delivery>()
                .HasKey(d => d.DeliveryId);

            modelBuilder.Entity<Status>()
                .HasKey(s => s.StatusId);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Driver)
                .WithMany()
                .HasForeignKey("DriverId");

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.DeliveryStatus)
                .WithMany()
                .HasForeignKey("StatusId");

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        UserId = 1,
                        UserName = "admin",
                        Password = "admin",
                        IsAdmin = true
                    },
                    new User
                    {
                        UserId = 2,
                        UserName = "driver",
                        Password = "driver",
                        IsAdmin = false
                    }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusId = 1,
                    StatusName = "In progress"
                },
                new Status
                {
                    StatusId = 2,
                    StatusName = "Finished"
                },
                new Status
                {
                    StatusId = 3,
                    StatusName = "Not Assigned"
                }
            );
        }
    }
}