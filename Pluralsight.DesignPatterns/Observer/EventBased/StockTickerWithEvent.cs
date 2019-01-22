using System;

namespace Pluralsight.DesignPatterns.Observer
{
    public class StockTickerWithEvent
    {
        private Stock _Stock;

        public Stock Stock
        {
            get { return _Stock; }
            set
            {
                _Stock = value;
                OnStockChange(new StockChangeEventArgs(_Stock));
            }
        }

        public event EventHandler<StockChangeEventArgs> StockChange;

        public virtual void OnStockChange(StockChangeEventArgs e)
        {
            StockChange?.Invoke(this, e);
        }
    }
}
