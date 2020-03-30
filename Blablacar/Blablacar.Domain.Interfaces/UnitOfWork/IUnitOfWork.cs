using System;

namespace Blablacar.Domain.Interfaces
{
    public interface IUnitOfWork<TDriversDto, TCustomersDto, TTripsDto> : IDisposable
    {
        IDriverRepository<TDriversDto> Drivers { get; }

        ICustomerRepository<TCustomersDto> Customers { get; }

        ITripRepository<TTripsDto> Trips { get; }

        void SaveChanges();
    }
}
