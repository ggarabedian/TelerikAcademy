namespace Decorator
{
    using System;
    using System.Collections.Generic;

    internal class LargePizza : Pizza
    {
        public LargePizza()
        {
            this.Price = 12.99m;
        }
    }
}