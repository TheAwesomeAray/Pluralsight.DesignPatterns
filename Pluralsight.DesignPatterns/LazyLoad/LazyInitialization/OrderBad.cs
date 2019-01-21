using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad
{
    public class OrderBad
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
            string result = _customer.CompanyName; //Bad practice,  may result in null reference exception
            return result + "\n" + Customer.Address;
        }

    }
}
