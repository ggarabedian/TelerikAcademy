namespace Decorator
{
    internal class OlivesTopping : ToppingsDecorator
    {
        public OlivesTopping(Pizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            this.Price = 0.99m;
        }
    }
}
