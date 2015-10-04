namespace XmlProcessingInDotNet
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public static class AlbumExtractor
    {
        public static void ExtractPricesBasedOnPublishYearXPath(string path, string pathQuery)
        {
            var catalogue = new XmlDocument();
            catalogue.Load(path);

            XmlNodeList albums = catalogue.SelectNodes(pathQuery);

            foreach (XmlNode album in albums)
            {
                int albumYear = int.Parse(album.SelectSingleNode("year").InnerText);

                if (DateTime.Now.Year - albumYear < 5)
                {
                    string albumName = album.SelectSingleNode("name").InnerText;
                    decimal albumPrice = decimal.Parse(album.SelectSingleNode("price").InnerText);

                    Console.WriteLine("Year: {0} - Album: {1} - Price: {2}", albumYear, albumName, albumPrice);
                }
            }
        }

        public static void ExtractPricesBasedOnPublishYearLinq(string path)
        {
            XDocument catalogue = XDocument.Load(path);

            var albums = from album in catalogue.Descendants("album")
                         where int.Parse(album.Element("year").Value) > (DateTime.Now.Year - 5)
                         select new
                         {
                             Name = album.Element("name").Value,
                             Year = album.Element("year").Value,
                             Price = album.Element("price").Value
                         };

            foreach (var album in albums)
            {
                Console.WriteLine("Year: {0} - Album: {1} - Price: {2}", album.Year, album.Name, album.Price);
            }
        }
    }
}
