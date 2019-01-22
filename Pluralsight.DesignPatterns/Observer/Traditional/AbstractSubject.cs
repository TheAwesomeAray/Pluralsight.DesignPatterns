using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Observer
{
    public abstract class AbstractSubject
    {
        List<Observer> observers = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
                o.Update();
        }
    }
}