using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public class Observer : IObserver
    {
        public virtual void update(IObservable observable)
        {
            Console.WriteLine("Implmented in child class");
        }
        public String findItem(IObservable observable)
        {
            if (observable is Iphone)
                return "IPHONE";
            return "LEDTV";
        }
    }
}
