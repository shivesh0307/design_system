using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public class SMS : Observer
    {
        string _smsNumber; 
        public SMS(string smsNumber) 
        {
            _smsNumber = smsNumber;
        }

        public override void update(IObservable observable)
        {
            String itemName = base.findItem(observable);
            Console.WriteLine($"{itemName} is back in stock");
            SendSMS(itemName);
        }
        public void SendSMS(String itemName) {
            Console.WriteLine($"SMS sent for {itemName} to {_smsNumber}");
        }
    }
}
