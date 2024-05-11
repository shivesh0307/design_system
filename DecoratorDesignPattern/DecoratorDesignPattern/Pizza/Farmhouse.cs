using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Pizza
{
    public class Farmhouse : BasePizza
    {
        public override int Cost()
        {
            return 200; 
        }
    }
}
