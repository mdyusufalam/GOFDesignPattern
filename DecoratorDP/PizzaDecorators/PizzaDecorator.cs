using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDP.Pizzas;

namespace DecoratorDP.PizzaDecorators
{
    public abstract class PizzaDecorator : IPizza
    {
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public abstract string GetDescription();


        public abstract string GetName();


        public abstract decimal GetPrice();
    }
}
