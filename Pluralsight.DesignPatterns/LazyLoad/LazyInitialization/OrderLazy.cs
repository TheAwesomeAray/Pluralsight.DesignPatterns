using System;

namespace Pluralsight.DesignPatterns.LazyLoad
{
    public class OrderLazy
    {
        private Lazy<Customer> _customerInitializer;

        public OrderLazy()
        {
            _customerInitializer = new Lazy<Customer>(() => new Customer()); // Database Call, is thread safe);
        }

        public Customer Customer
        {
            get
            {
                //With the lazy initializer, I don't have to worry about any null checks
                return _customerInitializer.Value;
            }
        }

        public string PrintLabel()
        {
            string result = Customer.CompanyName;
            return result + "/n" + _customerInitializer.Value.Address; // Ok to access
        }
    }
}
