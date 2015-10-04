namespace XmlProcessingInDotNet
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    public static class DirectoryTraverser
    {
        public static void TraverseDirectoryUsingXmlWriter(string path)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            string[] fileEntries = Directory.GetFiles(path);

            string directoryXml = "../../directoryXmlWriter.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(directoryXml, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();

                writer.WriteStartElement("dirs");

                foreach (var dir in subdirectoryEntries)
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("name", dir.TrimStart('/', '.'));
                    writer.WriteEndElement();
                }

                foreach (var file in fileEntries)
                {
                    writer.WriteStartElement("file");
                    writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                    writer.WriteAttributeString("ext", Path.GetExtension(file));
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            Console.WriteLine("Traversing directory... Done! The resulting xml file is in directoryXmlWriter.xml");
        }

        public static void TraverseDirectoryUsingXDocument(string path)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            string[] fileEntries = Directory.GetFiles(path);

            var dirs = new XElement("dirs");
            var directoryContent = new XDocument(dirs);
            
            foreach (var dir in subdirectoryEntries)
            {
                dirs.Add(new XElement("dir",
                    new XAttribute("name", dir.TrimStart('/', '.'))));
            }

            foreach (var file in fileEntries)
            {
                dirs.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            string directoryXml = "../../directoryXDocument.xml";
            directoryContent.Save(directoryXml);

            Console.WriteLine("Traversing directory... Done! The resulting xml file is in directoryXDocument.xml");
        }
    }
}
