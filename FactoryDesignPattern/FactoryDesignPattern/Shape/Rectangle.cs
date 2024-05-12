using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Shape
{
    public class Rectangle : IShape
    {
        int x, y; 
         public Rectangle(int x, int y)
        {
            this.x = x; 
            this.y = y; 
        }

        public void draw()
        {
            Console.WriteLine("Rectangle drawn"); ;
        }

        public double area()
        {
            return x*y;
        }
    }
}
