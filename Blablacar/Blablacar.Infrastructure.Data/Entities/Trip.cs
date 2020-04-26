using System;

namespace Blablacar.Infrastructure.Data
{
    public class Trip : BaseObject
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DepartureTime { get; set; }

        public Driver Driver { get; set; }

        public Customer Customer { get; set; }

        public int Price { get; set; }
    }
}
