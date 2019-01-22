namespace Pluralsight.DesignPatterns.LazyLoad
{
    public class OrderService
    {
        public virtual OrderDto GetDataUsingDataClientContract(int orderId)
        {
            return new OrderDto();
        }
    }
}
