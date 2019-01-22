using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Observer
{
    public static class ObserverProgram
    {
        public static void Run()
        {
            foreach (Stock s in SampleData.Stocks)
            {
                if (s.Symbol == "GOOG")
                    Console.WriteLine();

                if (s.Symbol == "MSFT")
                    Console.WriteLine();
            }
        }

        public static void RunWithObserver()
        {
            StockTicker subj = new StockTicker();

            GoogleObserver gobs = new GoogleObserver(subj);
            MicrosoftObserver mobs = new MicrosoftObserver(subj);

            foreach (var s in SampleData.Stocks)
                subj.Stock = s;
        }
    }
}
