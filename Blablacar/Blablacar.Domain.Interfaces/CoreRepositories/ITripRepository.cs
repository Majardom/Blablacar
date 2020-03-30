using Blablacar.Domain.Core;
using System;
using System.Collections.Generic;

namespace Blablacar.Domain.Interfaces
{
    public interface ITripRepository<TDto> : IGenericRepository<Trip, TDto>
    {
        IEnumerable<Trip> GetTripsForPeriod(DateTime start, DateTime end);
    }
}
