using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Shape
{
    public class Square : IShape
    {
        int _side;
        public Square(int side) { 
        _side= side;
        }

        public void draw()
        {
            Console.WriteLine("Square Drawn");
        }

        public double area()
        {
            return _side * _side;
        }
    }
}
