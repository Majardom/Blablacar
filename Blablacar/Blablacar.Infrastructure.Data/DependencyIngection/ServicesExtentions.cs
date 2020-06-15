using Blablacar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blablacar.Infrastructure.Data
{
    public static class ServicesExtentions
    {
        public static void AddBlablacarData(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork<Driver, Customer, Trip>, UnitOfWork>();
            services.AddScoped<ITripRepository<Trip>, TripRepository>();
            services.AddScoped<IDriverRepository<Driver>, DriverRepository>();
            services.AddScoped<ICustomerRepository<Customer>, CustomerRepository>();
            services.AddDbContext<BlablacarDbContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blablacar;Trusted_Connection=True;"));

        }
    }
}
