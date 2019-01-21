using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad.ValueHolder
{
    public class OrderItemLoader : IValueLoader<List<OrderItem>>
    {
        private readonly int _orderId;

        public OrderItemLoader(int orderId)
        {
            _orderId = orderId;
        }

        public List<OrderItem> Load()
        {
            //Realistically you would fetch from database here
            return new List<OrderItem>();
        }
    }
}
