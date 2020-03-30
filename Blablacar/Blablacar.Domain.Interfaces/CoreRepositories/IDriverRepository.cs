using Blablacar.Domain.Core;
using System.Collections.Generic;

namespace Blablacar.Domain.Interfaces
{
    public interface IDriverRepository<TDto> : IGenericRepository<Driver, TDto>
    {
        IEnumerable<Driver> GetDrivers(Gender gender);
    }
}
