using Blablacar.Domain.Core;

namespace Blablacar.Domain.Interfaces
{
    public interface ICustomerRepository<TDto> : IGenericRepository<Customer, TDto>
    {
    }
}
