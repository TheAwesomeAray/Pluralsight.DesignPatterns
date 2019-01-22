using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Observer
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Stock>> observers;
        private IObserver<Stock> observer;

        public Unsubscriber(List<IObserver<Stock>> observers, IObserver<StockTicker> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}