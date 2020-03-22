using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blablacar.Infrastructure.Data
{
    public class TripRepository : GenericRepository<TripDto>, ITripRepository
    {
        #region Constructors 

        public TripRepository(BlablacarDbContext context)
            :base(context)
        { }

        #endregion

        #region ITripRepository

        public IEnumerable<TripDto> GetTripsForPeriod(DateTime start, DateTime end)
        {
            return Entities
                .Where(x => x.DepartureTime > start && x.DepartureTime < end);
        }

        #endregion
    }
}
