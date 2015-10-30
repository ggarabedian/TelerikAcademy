namespace Decorator
{
    using System;
    using System.Collections.Generic;

    internal class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            this.Price = 7.99m;
        }
    }
}
