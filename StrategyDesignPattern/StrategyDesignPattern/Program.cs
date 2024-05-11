// See https://aka.ms/new-console-template for more information
// Strategy design pattern is used when the child classes instead of using parent functionality have their own implementation 
// And these implementation is same for some child classes leaading to duplication of code 
// Like in this case both child class OffRoadVehicle and SportyVehicle have same implementation for drive


using StrategyDesignPattern.Drive;
using StrategyDesignPattern.Vehicle;

Console.WriteLine("Hello, World!");
IDrive _normalDrive = new NormalDrive();
IDrive _sportyDrive = new SportyDrive();
NormalVehicle _normalVehicle = new NormalVehicle(_normalDrive);
_normalVehicle.Drive();
OffRoadVehicle _offRoadVehicle = new OffRoadVehicle(_sportyDrive);
_offRoadVehicle.Drive();
SportyVehicle _sportyVehicle = new SportyVehicle(_sportyDrive);
_sportyVehicle.Drive();
