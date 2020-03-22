using Blablacar.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace Blablacar.Infrastructure.Data
{
    public class BlablacarDbContext : DbContext
    {
        public DbSet<TripDto> Trips { get; set; }

        public DbSet<DriverDto> Drivers { get; set; }

        public DbSet<CustomerDto> Customers { get; set; }

        public BlablacarDbContext(DbContextOptions<BlablacarDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
