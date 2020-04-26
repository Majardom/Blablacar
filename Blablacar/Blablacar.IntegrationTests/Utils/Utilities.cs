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

        private static List<Infrastructure.Data.Customer> CreateCustomers()
        {
            return new List<Infrastructure.Data.Customer>
            {
                new Infrastructure.Data.Customer() { Name = "Drew", Gender = Gender.Male, PhoneNumber = "+380123456123" },
                new Infrastructure.Data.Customer() { Name = "Tom", Gender = Gender.Male, PhoneNumber = "+380123123456" },
                new Infrastructure.Data.Customer() { Name = "Katty", Gender = Gender.Female, PhoneNumber = "+380987654321" }
            };
        }

        private static List<Infrastructure.Data.Driver> CreateDrivers()
        {
            return new List<Infrastructure.Data.Driver>
            {
                new Infrastructure.Data.Driver() { Name = "John", Gender = Gender.Male, PhoneNumber = "+380123456789" },
                new Infrastructure.Data.Driver() { Name = "Mike", Gender = Gender.Male, PhoneNumber = "+380123123123" },
                new Infrastructure.Data.Driver() { Name = "Amy", Gender = Gender.Female, PhoneNumber = "+380987654321" },
            };
        }

        private static List<Infrastructure.Data.Trip> CrateTrips()
        {
            return new List<Infrastructure.Data.Trip>
            {
                new Infrastructure.Data.Trip() { From = "Lviv", To = "Kyiv" },
                new Infrastructure.Data.Trip() { From = "Lviv", To = "Lutsk" },
                new Infrastructure.Data.Trip() { From = "Symu", To = "Cherhigiv" }
            };
        }
    }
}
