﻿using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;

namespace Blablacar.Infrastructure.Data
{
    public class CustomerRepository : GenericRepository<Domain.Core.Customer, Customer>, ICustomerRepository<Customer>
    {
        #region Constructors 

        public CustomerRepository(BlablacarDbContext context, IMapper mapper)
            : base(context, mapper)
        { }

        #endregion

    }
}
