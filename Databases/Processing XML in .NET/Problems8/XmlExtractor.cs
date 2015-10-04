namespace XmlProcessingInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    public static class XmlExtractor
    {
        public static Dictionary<string,string> ReadArtistsAndAlbumsFromXmlFile(string path)
        {
            var albumsAndArtists = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "name"))
                    {
                        string albumName = reader.ReadElementString();

                        reader.ReadToNextSibling("artist");

                        string artist = reader.ReadElementString();

                        albumsAndArtists.Add(albumName, artist);
                    }
                }
            }

            return albumsAndArtists;
        }

        public static void WriteAlbumAndArtistsToXmlFile(Dictionary<string,string> albumsAndArtists)
        { 
            string albumXml = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(albumXml, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("personRepository");

                writer.WriteStartElement("albums");

                foreach (var item in albumsAndArtists)
                {
                    writer.WriteStartElement("album");
                    writer.WriteElementString("name", item.Key);
                    writer.WriteElementString("artist", item.Value);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            Console.WriteLine("Writing complete. album.xml file created.");
        }
    }
}
