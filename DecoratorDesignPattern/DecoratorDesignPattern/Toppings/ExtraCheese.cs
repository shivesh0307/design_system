using DecoratorDesignPattern.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Toppings
{
    public class ExtraCheese : Toppings
    {
        BasePizza _pizza;

        public ExtraCheese(BasePizza pizza)
        {
            _pizza = pizza;
        }

        public override int Cost()
        {
            return _pizza.Cost() + 10;
        }
    }
}
