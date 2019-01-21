using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad.Ghosts
{
    public class Order : DomainObject
    {
        public Order(int id) : base (id)
        { }

        private string _shipMethod;

        public string ShipMethod
        {
            get
            {
                Load();
                return _shipMethod;
            }
            set
            {
                Load();
                _shipMethod = value;
            }
        }

        private Customer _customer;

        public Customer Customer
        {
            get
            {
                Load();
                return _customer;
            }
            set
            {
                Load();
                _customer = value;
            }
        }

        public override void DoLoadLine(ArrayList dataRow)
        {
            ShipMethod = (string)dataRow[0];
            Customer = new Customer((int)dataRow[1]);
        }

        public override ArrayList GetDataRow()
        {
            var row = new ArrayList();
            row.Add("FEDEX");
            row.Add(123);
            return row;
        }
    }
}
