namespace EventAggregator
{
    public class OrderEventArgs
    {
        public Order Order { get; }

        public OrderEventArgs(Order order)
        {
            Order = order;
        }
    }
}