using Blablacar.Infrastructure.Data;
using Blablacar.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Blablacar.Infrastructure.Business
{
    public static class ServicesExtentions
    {
        public static void AddBlablacar(this IServiceCollection services)
        {
            services.AddBlablacarData();

            services.AddScoped<ITripService, TripService>();
        }
    }
}
