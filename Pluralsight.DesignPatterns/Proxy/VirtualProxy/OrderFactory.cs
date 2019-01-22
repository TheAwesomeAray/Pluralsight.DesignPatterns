using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Proxy
{
    class OrderFactory
    {
        public Order CreateFromId(int id)
        {
            return new OrderProxy()
            {
                Id = id
            };
        }
    }
}
