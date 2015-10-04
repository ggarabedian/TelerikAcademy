namespace XmlProcessingInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public static class DomParser
    {
        // using hash-table

        //public static void ExtractAllArtistsFromXml()
        //{
        //    var artists = new Hashtable();
        //    var catalogue = new XmlDocument();
        //    catalogue.Load("../../catalogue.xml");


        //    XmlNode rootNode = catalogue.DocumentElement;
        //    foreach (XmlNode node in rootNode.ChildNodes)
        //    {
        //        string currentArtist = node["artist"].InnerText;

        //        if (artists.ContainsKey(currentArtist))
        //        {
        //            artists[currentArtist] = (int)artists[currentArtist] + 1;
        //        }
        //        else
        //        {
        //            artists.Add(currentArtist, 1);
        //        }
        //    }

        //    foreach (DictionaryEntry artist in artists)
        //    {
        //        Console.WriteLine("{0} => {1} album/s", artist.Key, artist.Value);
        //    }
        //}

        public static void ExtractFromXml(string path, string node)
        {
            var artists = new Dictionary<string, int>();
            var catalogue = new XmlDocument();
            catalogue.Load(path);

            XmlNode rootNode = catalogue.DocumentElement;

            foreach (XmlNode xmlNode in rootNode.ChildNodes)
            {
                string currentArtist = xmlNode[node].InnerText;

                if (artists.ContainsKey(currentArtist))
                {
                    artists[currentArtist]++;
                }
                else
                {
                    artists.Add(currentArtist, 1);
                }
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("{0} => {1} album/s", artist.Key, artist.Value);
            }
        }

        public static void DeleteAlbumFromXmlBasedOnPrice(string path, string node, decimal maxPrice)
        {
            var catalogue = new XmlDocument();
            catalogue.Load(path);

            XmlNode rootNode = catalogue.DocumentElement;

            foreach (XmlNode album in rootNode.SelectNodes("album"))
            {
                decimal albumPrice = decimal.Parse(album[node].InnerText);

                if (albumPrice > maxPrice)
                {
                    rootNode.RemoveChild(album);
                }
            }

            catalogue.Save("../../modifiedCatalogue.xml");
        }
    }
}