using System;

namespace Blablacar.Domain.Core
{
    public class Trip : BaseObject
    {
        #region Properties

        public string From { get; private set; }

        public string To { get; private set; }

        public DateTime DepartureTime { get; private set; }

        public Driver Driver { get; private set; }

        public Customer Customer { get; private set; }

        public double Price { get; set; }

        #endregion

        #region Fluent API

        public Trip IsFrom(string from)
        {
            From = from.CheckForNull();

            return this;
        }

        public Trip IsTo(string to)
        {
            From = to.CheckForNull();

            return this;
        }

        public Trip DepatureOn(DateTime dateTime)
        {
            DepartureTime = dateTime;

            return this;
        }

        public Trip WithDriver(Driver driver)
        {
            Driver = driver.CheckForNull();

            return this;
        }

        public Trip WithCustomer(Customer customer)
        {
            Customer = customer.CheckForNull();

            return this;
        }

        #endregion
    }
}
