namespace TradeCompanyArticleDb
{
    using System;

    using Wintellect.PowerCollections;

    /*
    A large trade company has millions of articles, each described by barcode, vendor, title and price.
    Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
    Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET.
    */
    public class Startup
    {
        private static readonly Random rnd = new Random();

        public static void Main()
        {
            var articlesOriginal = new OrderedMultiDictionary<decimal, Article>(true);

            Console.Write("Generating 500 000 articles... ");
            GenerateArticles(articlesOriginal, 500000);

            Console.WriteLine("Done!");

            var articlesInPriceRange = articlesOriginal.Range(59500, true, 60000, true);

            Console.WriteLine("Articles with price between 59 500 and 60 000 inclusive: ");
            foreach (var articles in articlesInPriceRange)
            {
                foreach (var article in articles.Value)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} $", article.Title, article.Vendor, article.BarCode, article.Price);
                }
            }
        }

        private static void GenerateArticles(OrderedMultiDictionary<decimal, Article> articles, int numOfProductsToAdd)
        {
            for (int i = 0; i < numOfProductsToAdd; i++)
            {
                string barcode = rnd.Next(1000000, 9999999).ToString();
                string vendor = rnd.Next(i, 1000000).ToString();
                string title = rnd.Next(int.MaxValue).ToString();
                decimal price = rnd.Next(i / 100, 200000);

                var article = new Article(barcode, vendor, title, price);

                if (articles.ContainsKey(price))
                {
                    articles[price].Add(article);
                }
                else
                {
                    articles.Add(price, article);
                }
            }
        }
    }
}
