using Blablacar.Domain.Core;
using System.Collections.Generic;

namespace Blablacar.Services.Interfaces
{
    public interface ITripService
    {
        void OrderTrip(int tripId, Customer customer);

        void CreateTrip(Trip trip);

        IEnumerable<Trip> GetTrips();
    }
}
