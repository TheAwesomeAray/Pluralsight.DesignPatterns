using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad
{
    public class Customer
    {
        public Customer()
        {
                
        }

        public Customer(int id)
        {

        }

        public string Address { get; internal set; }
        public string CompanyName { get; internal set; }
        public DateTime DateOfBirth  { get; internal set; }
    }
}
