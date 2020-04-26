using Microsoft.EntityFrameworkCore;

namespace Blablacar.Infrastructure.Data
{
    public class BlablacarDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public BlablacarDbContext(DbContextOptions<BlablacarDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
