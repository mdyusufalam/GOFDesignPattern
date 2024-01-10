using DecoratorDP.Pizzas;

namespace DecoratorDP.PizzaDecorators
{
    public sealed class ExtraOliveDecorator : PizzaDecorator
    {
        private IPizza _pizza;
        public ExtraOliveDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override string GetName()
        {
            return _pizza.GetName() + "  with Extra Olive";
        }

        public override decimal GetPrice()
        {
            return _pizza.GetPrice()+1;
        }
    }
}
