namespace Decorator
{
    internal abstract class ToppingsDecorator : Pizza
    {
        protected ToppingsDecorator(Pizza pizzaToDecorate)
        {
            this.Pizza = pizzaToDecorate;
        }

        protected Pizza Pizza { get; private set; }

        public override decimal GetPrice()
        {
            return (this.Pizza.GetPrice() + this.Price);
        }
    }
}
