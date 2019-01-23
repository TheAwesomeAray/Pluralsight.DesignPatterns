namespace Pluralsight.DesignPatterns.Strategy
{
    public class UPSCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 4.00;
        }
    }
}
