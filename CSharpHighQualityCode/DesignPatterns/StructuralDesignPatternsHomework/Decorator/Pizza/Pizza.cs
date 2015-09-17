namespace Decorator
{
    using System;
    using System.Collections.Generic;

    internal abstract class Pizza
    {
        public decimal Price { get; set; }

        public virtual decimal GetPrice()
        {
            return this.Price;
        }
    }
}
