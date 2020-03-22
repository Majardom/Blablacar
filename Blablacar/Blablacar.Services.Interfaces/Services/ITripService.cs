using Blablacar.Domain.Core;
using System.Collections.Generic;

namespace Blablacar.Services.Interfaces
{
    public interface ITripService
    {
        void OrderTrip(int tripId, CustomerDto customer);

        void CreateTrip(TripDto trip);

        IEnumerable<TripDto> GetTrips();
    }
}
