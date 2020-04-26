using Blablacar.Domain.Core;

namespace Blablacar.Dtos
{
    public abstract class PersonDto : BaseObjectDto
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }
    }
}
