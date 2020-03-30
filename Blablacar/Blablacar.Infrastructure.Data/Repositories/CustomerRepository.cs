using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;

namespace Blablacar.Infrastructure.Data
{
    public class CustomerRepository : GenericRepository<Customer, CustomerDto>, ICustomerRepository<CustomerDto>
    {
        #region Constructors 

        public CustomerRepository(BlablacarDbContext context, IMapper mapper)
            : base(context, mapper)
        { }

        #endregion

    }
}
