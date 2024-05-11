using ObserverDesignPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observer
{
    public class Email : Observer
    {
        String _email;
        public Email(String email) {
            _email = email;
        }
        public override void update(IObservable observable)
        {
            String itemName = base.findItem(observable);
            Console.WriteLine($"{itemName} is back in stock");
            SendEmail(itemName);
        }
        public void SendEmail(String itemName)
        {
            Console.WriteLine($"Email sent for {itemName} to {_email}");
        }
    }
}
