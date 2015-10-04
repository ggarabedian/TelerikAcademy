namespace XmlProcessingInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public static class XPath
    {
        public static void ExtractFromXml(string path, string node, string pathQuery)
        {
            var artists = new Dictionary<string, int>();
            var catalogue = new XmlDocument();
            catalogue.Load(path);

            XmlNodeList queryList = catalogue.SelectNodes(pathQuery);

            foreach (XmlNode xmlNode in queryList)
            {
                string currentArtist = xmlNode.SelectSingleNode(node).InnerText;

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
    }
}
