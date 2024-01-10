using DecoratorDP.PizzaDecorators;
using DecoratorDP.Pizzas;

namespace BakePizza
{
    public class Program
    {

        public static void Main()
        {
            List<IPizza> pizzas = new List<IPizza> { new MargheritaPizza(), new FarmhousePizza(), new CheeseNCorn() };
            
            var pizzaOrder = new PizzaOrder();
            pizzaOrder.getPizzaList(pizzas);

            int pizzaSl = pizzaOrder.takePizzaOrder();
            if(pizzaSl>pizzas.Count-1) {
                Console.WriteLine("OOPS! Wrong SL No.");
                pizzaSl = pizzaOrder.takePizzaOrder();
            }
            Console.Write($"\nAdd extra topping on {pizzas.ElementAt(pizzaSl).GetName() + " pizza [y/n]"}?");
            bool IsToppingApplicable = pizzaOrder.IsExtraToppingRequired();
            
            // pizza selected my the customer
            var pizza = pizzas.ElementAt(pizzaSl);

            if (IsToppingApplicable)
            {
              
                //Add logging to add extra topping on it.
                List<IPizza> pizzaToppings = new List<IPizza> { new ExtraCheeseDecorator(pizza), new ExtraOliveDecorator(pizza), new ExtraOnionDecorator(pizza) };
                pizzaOrder.getToppingList(pizzaToppings, pizza);
                int toppingSelected = pizzaOrder.SelectTopping();
                pizza = pizzaToppings.ElementAt(toppingSelected);
            }

            pizzaOrder.OrderPlaced(pizza);

            async Task BackPizzaAsync()
            {
                await Task.Run(() => BakingOven.BakePizza(pizza));
            }
            // BackPizzaAsync();
            BakingOven.BakePizza(pizza);
            pizzaOrder.OrderCompleted();
            Main();
        }
    }
}


