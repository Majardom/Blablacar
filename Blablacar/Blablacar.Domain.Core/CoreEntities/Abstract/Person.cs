namespace Blablacar.Domain.Core
{
    public enum Gender
    {
        Male,
        Female
    }

    public abstract class Person : BaseObject
    {
        #region Properties

        public string Name { get; private set; }

        public Gender Gender { get; private set; }

        public string PhoneNumber { get; private set; }

        #endregion

        #region Fluent API

        public Person WithName(string name)
        {
            Name = name.CheckForNull();

            return this;
        }

        public Person Is(Gender gender)
        {
            Gender = gender;

            return this;
        }

        public Person WithPhoneNumber(string number)
        {
            PhoneNumber = number.CheckForNull();

            return this;
        }

        #endregion
    }
}
