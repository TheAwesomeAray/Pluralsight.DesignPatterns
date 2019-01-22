using System;

namespace Pluralsight.DesignPatterns.Observer
{
    class MicrosoftMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            // Done
        }

        public void OnError(Exception error)
        {
            //Error
        }

        public void OnNext(Stock stock)
        {
            if (stock.Symbol == "GOOG")
                Console.WriteLine($"Google's new price is: {stock.Price}");

        }
    }
}
