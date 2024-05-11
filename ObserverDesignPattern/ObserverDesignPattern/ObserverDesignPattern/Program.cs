// See https://aka.ms/new-console-template for more information
using ObserverDesignPattern.Observable;
using ObserverDesignPattern.Observer;

Console.WriteLine("Hello, World!");

IObservable _iphone = new Iphone();
IObservable _ledtv = new LedTv();

IObserver _email = new Email("shivesh@gmail");
IObserver _email2 = new Email("shivesh1233@gmail");
IObserver _sms = new SMS("12233434");
IObserver _sms2 = new SMS("122334342398883838434989");
_iphone.add(_email);
_iphone.add(_email2);
_iphone.add(_sms);

_ledtv.add(_email);
_ledtv.add(_sms);
_ledtv.add(_sms2);


_iphone.setData(5);
_ledtv.setData(6);

_iphone.setData(10);
_ledtv.setData(16);