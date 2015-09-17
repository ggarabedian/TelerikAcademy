namespace Decorator
{
    internal class HamTopping : ToppingsDecorator
    {
        public HamTopping(Pizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            this.Price = 2.99m;
        }
    }
}
