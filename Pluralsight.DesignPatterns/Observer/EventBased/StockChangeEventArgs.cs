namespace Pluralsight.DesignPatterns.Observer
{
    public class StockChangeEventArgs
    {
        public readonly Stock Stock;

        public StockChangeEventArgs(Stock stock)
        {
            Stock = stock;
        }
    }
}