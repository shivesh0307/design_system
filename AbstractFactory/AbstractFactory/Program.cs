// See https://aka.ms/new-console-template for more information
// Facotry of Factories

using AbstractFactory.Factory;
using AbstractFactory.Vehicle;
using AbstractFactory.VehicleFactory;

Console.WriteLine("Hello, World!");

Factory factory= new Factory();

IVehicleFactory vehicleFactoryLuxury = factory.GetVehicleFactory(1);
IVehicleFactory vehicleFactoryOrdinary = factory.GetVehicleFactory(0);

IVehicle BMW = vehicleFactoryLuxury.GetVehicle("BMW");
BMW.drive();


IVehicle Suzuki = vehicleFactoryOrdinary.GetVehicle("Suzuki");
Suzuki.drive();



