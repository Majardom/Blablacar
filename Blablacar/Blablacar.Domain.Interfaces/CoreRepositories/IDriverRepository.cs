using Blablacar.Domain.Core;
using System.Collections.Generic;

namespace Blablacar.Domain.Interfaces
{
    public interface IDriverRepository : IGenericRepository<DriverDto>
    {
        IEnumerable<DriverDto> GetDrivers(Gender gender);
    }
}
