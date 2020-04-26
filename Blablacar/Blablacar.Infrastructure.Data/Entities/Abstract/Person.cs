using Blablacar.Domain.Core;

namespace Blablacar.Infrastructure.Data
{
    public abstract class Person : BaseObject
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }
    }
}
