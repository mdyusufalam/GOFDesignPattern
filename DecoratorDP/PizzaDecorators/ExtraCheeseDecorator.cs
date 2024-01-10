using DecoratorDP.Pizzas;

namespace DecoratorDP.PizzaDecorators
{
    public sealed class ExtraCheeseDecorator : PizzaDecorator
    {
        private IPizza _pizza;
        public ExtraCheeseDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override string GetName()
        {
            return _pizza.GetName() + " with Extra Cheese";
        }

        public override decimal GetPrice()
        {
            return _pizza.GetPrice() + 2;
        }
    }
}
