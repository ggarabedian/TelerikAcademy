namespace XmlProcessingInDotNet
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public static class SchemaValidator
    {
        public static void ValidateSchema(string path)
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalogue.xsd");

            XDocument doc = XDocument.Load(path);
            XDocument invalidDoc = XDocument.Load("../../invalidCatalogue.xml");

            PrintResult(doc, schema, "catalogue.xml");
            PrintResult(invalidDoc, schema, "invalidCatalogue.xml");
        }

        private static void PrintResult(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("{0} - {1}", file, ev.Message);
            });
        }
    }
}
