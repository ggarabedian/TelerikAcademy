namespace Decorator
{
    internal class ChickenTopping : ToppingsDecorator
    {
        public ChickenTopping(Pizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            this.Price = 2.99m;
        }
    }
}
