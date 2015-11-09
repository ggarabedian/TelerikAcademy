namespace TradeCompanyArticleDb
{
    using System;

    public class Article : IComparable<Article>
    {
        public Article(string barCode, string vendor, string title, decimal price)
        {
            this.BarCode = barCode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string BarCode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return (int)(this.Price - other.Price);
        }
    }
}
