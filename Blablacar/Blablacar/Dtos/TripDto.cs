using System;

namespace Blablacar.Dtos
{
    public class TripDto : BaseObjectDto
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DepartureTime { get; set; }

        public DriverDto Driver { get; set; }

        public CustomerDto Customer { get; set; }

        public int Price { get; set; }
    }
}
