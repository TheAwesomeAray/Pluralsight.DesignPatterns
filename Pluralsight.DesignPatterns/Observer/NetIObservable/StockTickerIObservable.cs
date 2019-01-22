using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Observer
{
    class StockTickerIObservable : IObservable<Stock>
    {
        List<IObserver<Stock>> observers = new List<IObserver<Stock>>();

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

        public void Notify()
        {
            foreach (var o in observers)
            {
                if (_Stock.Price < 0)
                    o.OnError(new Exception("Bad Data"));
                else
                    o.OnNext(_Stock);
            }
        }

        public void Stop()
        {
            observers.Clear();
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
    }
}
