using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System;

namespace Blablacar.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDriverRepository Drivers { get; }

        public ICustomerRepository Customers { get; }

        public ITripRepository Trips { get; }

        #region Constructors 

        public UnitOfWork(IDriverRepository drivers, 
            ICustomerRepository customers, 
            ITripRepository trips)
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
