using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Proxy.CachedRepository
{
    public class OrderRepository
    {
        public virtual Order GetOrder(int id)
        {
            return new Order();
        }
    }
}
