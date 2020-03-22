using System;

namespace Blablacar.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDriverRepository Drivers { get; }

        ICustomerRepository Customers { get; }

        ITripRepository Trips { get; }

        void SaveChanges();
    }
}
