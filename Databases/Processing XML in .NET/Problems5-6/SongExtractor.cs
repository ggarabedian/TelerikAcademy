namespace XmlProcessingInDotNet
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public static class SongExtractor
    {
        public static void ExtractSongsUsingXmlReader(string path, string node)
        {
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == node))
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }
        }

        public static void ExtractSongsUsingXDocument(string path, string node)
        {
            XDocument catalogue = XDocument.Load(path);

            var songs = from song in catalogue.Descendants(node)
                        select song;

            foreach (XElement song in songs)
                Console.WriteLine(song.Value);
        }
    }
}