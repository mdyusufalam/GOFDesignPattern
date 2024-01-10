using DecoratorDP.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakePizza
{
    public  class BakingOven
    {
        public static void BakePizza(IPizza pizza)
        {
            Console.WriteLine($"Backing Started...");
            Thread.Sleep(1000);
            Console.WriteLine($"Backing Completed.");
        }
    }
}
