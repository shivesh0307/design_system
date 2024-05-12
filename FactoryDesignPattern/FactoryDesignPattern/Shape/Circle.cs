using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Shape
{
    public class Circle : IShape
    {
        int _radius;
        public Circle(int radius) {
            _radius = radius;
        }

        public void draw()
        {
            Console.WriteLine("Drawn Circle");
        }
        public double area()
        {
            return _radius * _radius *  Math.PI;
        }
        
    }
}
