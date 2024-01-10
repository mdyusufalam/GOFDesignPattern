using DecoratorDP.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakePizza
{
    public class PizzaOrder
    {
        public void getPizzaList(IEnumerable<IPizza> pizzas)
        {
        
            Console.WriteLine("Choose your pizza by entering Sl No. ");
            int Index = 1;
            foreach (IPizza pizza in pizzas)
            {
                Console.WriteLine($"SL:{Index}, Name:{pizza.GetName()}, Price:{pizza.GetPrice()} "
                    //$"\nDescription: {pizza.GetDescription()}." +
                    );
                Index++;
            }
        }

        public void getToppingList(IEnumerable<IPizza> Toppings, IPizza pizza)
        {
            Console.WriteLine($"\nAdd topping on {pizza.GetName()} by entering Sl No.");
            int Index = 1;
            foreach (IPizza topping in Toppings)
            {
                Console.WriteLine($"SL:{Index}, Name:{topping.GetName()}, Price:{topping.GetPrice()} " +
                    //$"\nDescription: {topping.GetDescription()}" +
                    $"");
                Index++;
            }
        }



        public int takePizzaOrder()
        {
           
            Console.WriteLine("Please enter SL No. to place order.");
            int pizzaSL = 0;
            int.TryParse(Console.ReadLine(), out pizzaSL);
            if (pizzaSL == 0)
            {
                Console.WriteLine("OOPS! Wrong SL No.");
                return takePizzaOrder();
            }
            return pizzaSL-1;
        }
        public bool IsExtraToppingRequired()
        {

            char toppingRequired = Console.ReadKey().KeyChar;
            if(toppingRequired=='y') return true;
            return false;
        }

        public int SelectTopping()
        {
            Console.WriteLine("Please enter SL No. to apply topping on your awesome PIZZA!");
            int pizzaToppingSL = 0; 
            int.TryParse(Console.ReadLine(), out pizzaToppingSL);
            if (pizzaToppingSL == 0)
            {
                Console.WriteLine("OOPS! Wrong SL No.");
                return SelectTopping();
            }
            return pizzaToppingSL - 1;
        }

        public void OrderPlaced(IPizza pizza)
        {
            Console.WriteLine($"Thank you for your order, Please wait preparing your mouth watering {pizza.GetName()} PIZZA!\r\n");
            Console.WriteLine($"Name: {pizza.GetName()}, Price: ${pizza.GetPrice()}\r\n{pizza.GetDescription()}");
            Console.WriteLine($"====================================Order Placed====================================\r\n\r\r");
        }

        public void OrderCompleted()
        {
            Console.WriteLine($"\r\n***********************************Order Completed********************************\r\n\r\r");
        }

    }
}
