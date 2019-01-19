namespace Pluralsight.DesignPatterns.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza { get; }

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override decimal CalucateCost()
        {
            return _pizza.CalucateCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
