namespace Decorator
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine(new string('*', 20));
            var pizza = new LargePizza();
            Console.WriteLine("Large pizza price: " + pizza.GetPrice());

            Console.WriteLine(new string('*', 20));
            var pizzaWithHam = new HamTopping(pizza);
            Console.WriteLine("Large pizza with ham price: " + pizzaWithHam.GetPrice());
            
            Console.WriteLine(new string('*', 20));
            var pizzaWithHamAndOlives = new OlivesTopping(pizzaWithHam);
            Console.WriteLine("Large pizza with ham and olives price: " + pizzaWithHamAndOlives.GetPrice());       
        }
    }
}
