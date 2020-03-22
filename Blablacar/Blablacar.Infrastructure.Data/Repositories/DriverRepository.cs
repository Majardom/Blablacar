using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Blablacar.Infrastructure.Data
{
    public class DriverRepository : GenericRepository<DriverDto>, IDriverRepository
    {
        #region Constructors 

        public DriverRepository(BlablacarDbContext context)
            : base(context)
        { }

        #endregion

        #region IDriverRepository

        public IEnumerable<DriverDto> GetDrivers(Gender gender)
        {
            return Entities
                .Where(x => x.Gender == gender);
        }

        #endregion
    }
}
