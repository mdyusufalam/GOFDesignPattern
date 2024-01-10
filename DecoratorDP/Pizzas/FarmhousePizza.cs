namespace DecoratorDP.Pizzas
{
    public sealed class FarmhousePizza : IPizza
    {
        public string GetDescription()
        {
            return "Delightful combination of onion, capsicum, tomato & grilled mushroom";
        }

        public string GetName()
        {
            return "Farmhouse";
        }

        public decimal GetPrice()
        {
            return 4.55M;
        }


    }
}
