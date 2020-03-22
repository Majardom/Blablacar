using System;

namespace Blablacar.Domain.Core
{
    public class TripDto : BaseObject
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DepartureTime { get; set; }

        public DriverDto Driver { get; set; }

        public CustomerDto Customer { get; set; }
    }
}
