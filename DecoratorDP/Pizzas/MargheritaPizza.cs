namespace DecoratorDP.Pizzas
{
    public sealed class MargheritaPizza : IPizza
    {
        public string GetDescription()
        {
            return "Classic delight with 100% real mozzarella cheese";
        }

        public string GetName()
        {
            return "Margherita";
        }

        public decimal GetPrice()
        {
            return 5.0M;
        }


    }
}
