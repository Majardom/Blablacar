using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blablacar.Infrastructure.Data
{
    public class TripRepository : GenericRepository<Domain.Core.Trip, Trip>, ITripRepository<Trip>
    {
        #region Constructors 

        public TripRepository(BlablacarDbContext context, IMapper mapper)
            :base(context, mapper)
        { }

        #endregion

        #region ITripRepository

        public IEnumerable<Domain.Core.Trip> GetTripsForPeriod(DateTime start, DateTime end)
        {
            return Mapper.Map<IEnumerable<Domain.Core.Trip>>(Entities
                .Where(x => x.DepartureTime > start && x.DepartureTime < end));
        }

        #endregion
    }
}
