namespace DecoratorDP.Pizzas
{
    public sealed class CheeseNCorn : IPizza
    {
        public string GetDescription()
        {
            return "A delectable combination of sweet & juicy golden corn";
        }

        public string GetName()
        {
            return "Cheese & Corn";
        }

        public decimal GetPrice()
        {
            return 6.55M;
        }


    }
}
