namespace EfficientSearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        static void Main()
        {
            var products = new OrderedBag<Product>();

            Console.Write("Adding products... ");
            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product("Product #" + (i + 1), (i % 100) + (decimal)i / 100));
            }

            Console.WriteLine("Done!");

            Console.WriteLine("Searching products by different price ranges: ");
            var productsWithPrice5to15 = GetProductsByPriceRange(products, 5, 15, 20);
            var productsWithPrice15to25 = GetProductsByPriceRange(products, 15, 25, 20);

            Console.WriteLine("First 20 products with prices from 5 to 15");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPrice5to15));
            Console.WriteLine("First 20 products with prices from 15 to 20");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPrice15to25));
        }

        static IEnumerable<Product> GetProductsByPriceRange(OrderedBag<Product> products, decimal minPrice, decimal maxPrice, int count)
        {
            var result =
                products.Range(
                    products.FirstOrDefault(x => x.Price >= minPrice),
                    true,
                    products.LastOrDefault(x => x.Price <= maxPrice),
                    true).Take(count);

            return result;
        }
    }
}
