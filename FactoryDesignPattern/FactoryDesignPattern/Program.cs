// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.Shape;
using FactoryDesignPattern.ShapeFactory;

Console.WriteLine("Hello, World!");

ShapeFactory shapeFactory= new ShapeFactory();

IShape circle = shapeFactory.GetShape("Circle");
circle.draw();
IShape square = shapeFactory.GetShape("Square");
square.draw();

IShape rectangle = shapeFactory.GetShape("Rectangle");

rectangle.draw();

