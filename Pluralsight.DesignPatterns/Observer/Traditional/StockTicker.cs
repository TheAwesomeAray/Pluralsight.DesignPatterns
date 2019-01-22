namespace Pluralsight.DesignPatterns.Observer
{
    public class StockTicker : AbstractSubject
    {
        private Stock _Stock;

        public Stock Stock
        {
            get { return _Stock; }
            set
            {
                _Stock = value;
                Notify();
            }
        }

    }
}