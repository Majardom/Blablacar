using Blablacar.Domain.Core;
using System;
using System.Collections.Generic;

namespace Blablacar.Domain.Interfaces
{
    public interface ITripRepository : IGenericRepository<TripDto>
    {
        IEnumerable<TripDto> GetTripsForPeriod(DateTime start, DateTime end);
    }
}
