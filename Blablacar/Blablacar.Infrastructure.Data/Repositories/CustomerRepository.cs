using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;

namespace Blablacar.Infrastructure.Data
{
    public class CustomerRepository : GenericRepository<CustomerDto>, ICustomerRepository
    {
        #region Constructors 

        public CustomerRepository(BlablacarDbContext context)
            : base(context)
        { }

        #endregion

    }
}
