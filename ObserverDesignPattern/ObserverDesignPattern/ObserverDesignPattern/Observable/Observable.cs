using ObserverDesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observable
{
    public class Observable : IObservable
    {
        int stock; 
        List<IObserver> _observer;

        public Observable()
        {
            _observer = new List<IObserver>();
            stock = 0;
        }
        public void add(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void notify()
        {
            foreach(var observer in _observer)
            {
                observer.update(this);
            }
        }

        public void remove(IObserver observer)
        {
           _observer.Remove(observer);
        }

        public void setData(int newValue)
        {
            if(stock==0)
            {
                notify();
            }
            stock = newValue;
        }
    }
}
