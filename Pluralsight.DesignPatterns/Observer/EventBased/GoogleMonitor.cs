using System;

namespace Pluralsight.DesignPatterns.Observer
{
    public class GoogleMonitor
    {
        public GoogleMonitor(StockTickerWithEvent subj)
        {
            subj.StockChange += new EventHandler<StockChangeEventArgs>(StockTicker_StockChange);
        }

        void StockTicker_StockChange(object sender, StockChangeEventArgs e)
        {
            CheckFilter(e.Stock);
        }
        public void CheckFilter(Stock stock)
        {
            if (stock.Symbol == "GOOG")
                Console.WriteLine($"Google's new price is: {stock.Price}");

        }
    }
}
