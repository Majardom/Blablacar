using System;

namespace Blablacar.Infrastructure.Data
{
    public class TripDto : BaseObjectDto
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DepartureTime { get; set; }

        public DriverDto Driver { get; set; }

        public CustomerDto Customer { get; set; }
    }
}
