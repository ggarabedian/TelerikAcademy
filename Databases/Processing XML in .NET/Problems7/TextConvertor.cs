namespace XmlProcessingInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    public static class TextConvertor
    {
        public static void ConvertTxtToXml(string path)
        {
            var sr = new StreamReader(path);
            var personInfo = new List<string>();
            string fileConvertedToXml = "../../PersonInfo.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileConvertedToXml, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("personRepository");

                string currentLine = sr.ReadLine();
                while (currentLine != null)
                {
                    personInfo.Add(currentLine);
                    currentLine = sr.ReadLine();
                }

                writer.WriteStartElement("person");
                writer.WriteElementString("name", personInfo[0]);
                writer.WriteElementString("address", personInfo[1]);
                writer.WriteElementString("phoneNumber", personInfo[2]);
                writer.WriteEndElement();
            }

            Console.WriteLine("Conversion complete. Xml file PersonInfo.xml created.");
        }
    }
}
