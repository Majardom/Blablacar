using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System;

namespace Blablacar.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork<Driver, Customer, Trip>
    {
        public IDriverRepository<Driver> Drivers { get; }

        public ICustomerRepository<Customer> Customers { get; }

        public ITripRepository<Trip> Trips { get; }

        #region Constructors 

        public UnitOfWork(IDriverRepository<Driver> drivers, 
            ICustomerRepository<Customer> customers, 
            ITripRepository<Trip> trips)
        {
            Drivers = drivers.CheckForNull();

            Customers = customers.CheckForNull();

            Trips = trips.CheckForNull();
        }

        #endregion

        #region Methods

        public void SaveChanges()
        {
            Drivers.Save();
            Customers.Save();
            Trips.Save();
        }

        #endregion

        #region IDisposable

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;

            if (disposing)
            {
                Drivers.Dispose();
                Customers.Dispose();
                Trips.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        #endregion
    }
}
