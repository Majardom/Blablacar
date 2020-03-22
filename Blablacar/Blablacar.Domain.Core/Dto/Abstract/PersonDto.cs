namespace Blablacar.Domain.Core
{
    public abstract class PersonDto : BaseObject
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }
    }
}
