using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad
{
    class OrderGood
    {
        private Customer _customer;

        public Customer Customer
        {
            get
            {
                if (_customer == null)
                {
                    //Go to database
                    //Not thread safe
                    _customer = new Customer();
                }
                return _customer;
            }
        }

        public string PrintLabel()
        {
            return Customer.CompanyName + "\n" + Customer.Address; // No chance of null reference exception
        }
    }
}
