using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Blablacar.Infrastructure.Data
{
    public class DriverRepository : GenericRepository<Driver, DriverDto>, IDriverRepository<DriverDto>
    {
        #region Constructors 

        public DriverRepository(BlablacarDbContext context, IMapper mapper)
            : base(context, mapper)
        { }

        #endregion

        #region IDriverRepository

        public IEnumerable<Driver> GetDrivers(Gender gender)
        {
            return Mapper.Map<IEnumerable<Driver>>(Entities
                .Where(x => x.Gender == gender));
        }

        #endregion
    }
}
