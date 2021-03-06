﻿using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using Blablacar.Infrastructure.Data;
using Blablacar.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blablacar.Infrastructure.Business
{
    public class TripService : BaseService, ITripService
    {
        #region Constructors 

        public TripService(IUnitOfWork<Data.Driver, Data.Customer, Data.Trip> unitOfWork, IMapper mapper)
            :base(unitOfWork, mapper)
        { }

        #endregion

        #region ITripService

        public void OrderTrip(int tripId, Domain.Core.Customer customer)
        {
            var trip = UnitOfWork.Trips.Get(tripId).CheckForNull();

            trip.WithCustomer(customer);

            UnitOfWork.Trips.Update(trip);
            UnitOfWork.SaveChanges();
        }

        public void CreateTrip(Domain.Core.Trip trip)
        {
            trip.CheckForNull();

            var dbTrip = UnitOfWork.Trips.GetAll().FirstOrDefault(x => x.Id == trip.Id);

            if (dbTrip != null)
            {
                if (dbTrip.Driver != null)
                    throw new InvalidOperationException("Trip already exists");

                UnitOfWork.Trips.Update(trip);
            }
            else
                UnitOfWork.Trips.Create(trip);              

            UnitOfWork.SaveChanges();
        }

        public IEnumerable<Domain.Core.Trip> GetTrips()
        {
            return UnitOfWork.Trips.GetAll();
        }

        #endregion
    }
}
