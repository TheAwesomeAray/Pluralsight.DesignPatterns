using System;

namespace Pluralsight.DesignPatterns.Observer
{
    public class GoogleObserver : Observer
    {
        private StockTicker DataSource { get; set; }

        public GoogleObserver(StockTicker subj)
        {
            DataSource = subj;
            subj.Subscribe(this);
        }

        public override void Update()
        {
            if (DataSource.Stock.Symbol == "GOOG")
                Console.WriteLine($"Google's new price is: {DataSource.Stock.Price}");

        }
    }
}