using Blablacar.Domain.Core;
using Blablacar.Infrastructure.Data;
using System.Collections.Generic;

namespace Blablacar.IntegrationTests.Utils
{
    public class Utilities
    {
        public static void InitDbForTests(BlablacarDbContext context)
        {
            context.Trips.AddRange(CrateTrips());
            context.Drivers.AddRange(CreateDrivers());
            context.Customers.AddRange(CreateCustomers());
        }

        private static List<CustomerDto> CreateCustomers()
        {
            return new List<CustomerDto>
            {
                new CustomerDto() { Name = "Drew", Gender = Gender.Male, PhoneNumber = "+380123456123" },
                new CustomerDto() { Name = "Tom", Gender = Gender.Male, PhoneNumber = "+380123123456" },
                new CustomerDto() { Name = "Katty", Gender = Gender.Female, PhoneNumber = "+380987654321" }
            };
        }

        private static List<DriverDto> CreateDrivers()
        {
            return new List<DriverDto>
            {
                new DriverDto() { Name = "John", Gender = Gender.Male, PhoneNumber = "+380123456789" },
                new DriverDto() { Name = "Mike", Gender = Gender.Male, PhoneNumber = "+380123123123" },
                new DriverDto() { Name = "Amy", Gender = Gender.Female, PhoneNumber = "+380987654321" },
            };
        }

        private static List<TripDto> CrateTrips()
        {
            return new List<TripDto>
            {
                new TripDto() { From = "Lviv", To = "Kyiv" },
                new TripDto() { From = "Lviv", To = "Lutsk" },
                new TripDto() { From = "Symu", To = "Cherhigiv" }
            };
        }
    }
}
