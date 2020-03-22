using Blablacar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blablacar.Infrastructure.Data
{
    public static class ServicesExtentions
    {
        public static void AddBlablacarData(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITripRepository, TripRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddDbContext<BlablacarDbContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blablacar;Trusted_Connection=True;"));
        }
    }
}
