using DecoratorDP.Pizzas;

namespace DecoratorDP.PizzaDecorators
{
    public sealed class ExtraOnionDecorator : PizzaDecorator
    {
        private IPizza _pizza;
        public ExtraOnionDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override string GetName()
        {
            return _pizza.GetName()+ " with Extra Onion"; 
        }

        public override decimal GetPrice()
        {
            return _pizza.GetPrice() + 1;
        }
    }
}
