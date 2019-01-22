using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.LazyLoad
{
    public class RemoteOrderService : OrderService
    {
        public override OrderDto GetDataUsingDataClientContract(int orderId)
        {
            return GetOrderDtoFromWCFService();
        }

        private OrderDto GetOrderDtoFromWCFService()
        {
            //Get From some WCF Service defined in another assembly
            return new OrderDto();
        }
    }
}
