using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Observer
{
    public class MicrosoftObserver : Observer
    {
        private StockTicker DataSource { get; set; }

        public MicrosoftObserver(StockTicker subj)
        {
            DataSource = subj;
            subj.Subscribe(this);
        }

        public override void Update()
        {
            if (DataSource.Stock.Symbol == "MSFT")
                Console.WriteLine($"Micrsoft's new price is: {DataSource.Stock.Price}");

        }
    }
}
