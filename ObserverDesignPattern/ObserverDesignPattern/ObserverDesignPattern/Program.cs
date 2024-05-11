// See https://aka.ms/new-console-template for more information
using ObserverDesignPattern.Observable;
using ObserverDesignPattern.Observer;

Console.WriteLine("Hello, World!");

IObservable _iphone = new Iphone();
IObservable _ledtv = new LedTv();

IObserver _email = new Email();
IObserver _sms= new SMS();

_iphone.add(_email);
_iphone.add(_sms);

_ledtv.add(_sms);


_iphone.setData(5);
_ledtv.setData(6);