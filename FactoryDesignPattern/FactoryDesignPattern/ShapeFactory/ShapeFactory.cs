using FactoryDesignPattern.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ShapeFactory
{
    public class ShapeFactory
    {
        public IShape GetShape(String shape)
        {
            if (shape == "Square")
                return new Square(5);
            else if (shape == "Circle")
                return new Circle(5);
            else
                return new Rectangle(5, 7);
        }
    }
}
