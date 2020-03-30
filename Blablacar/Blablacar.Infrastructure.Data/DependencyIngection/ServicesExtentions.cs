using Blablacar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blablacar.Infrastructure.Data
{
    public static class ServicesExtentions
    {
        public static void AddBlablacarData(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork<DriverDto, CustomerDto, TripDto>, UnitOfWork>();
            services.AddScoped<ITripRepository<TripDto>, TripRepository>();
            services.AddScoped<IDriverRepository<DriverDto>, DriverRepository>();
            services.AddScoped<ICustomerRepository<CustomerDto>, CustomerRepository>();
            services.AddDbContext<BlablacarDbContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blablacar;Trusted_Connection=True;"));
        }
    }
}
