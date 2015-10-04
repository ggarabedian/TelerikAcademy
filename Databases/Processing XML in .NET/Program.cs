namespace XmlProcessingInDotNet
{
    using System;
    using System.Xml.Xsl;

    public class Program
    {
        public static void Main()
        {
            // 2. Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash - table.
            const string CataloguePath = "../../catalogue.xml";
            string node = "artist";

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("2. Using DOM Parser");
            Console.WriteLine(new string('-', 25));

            DomParser.ExtractFromXml(CataloguePath, node);

            Console.WriteLine();

            // 3. Implement the previous using XPath.
            string pathQuery = "/catalogue/album";

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("3. Using XPath");
            Console.WriteLine(new string('-', 25));

            XPath.ExtractFromXml(CataloguePath, node, pathQuery);

            Console.WriteLine();

            // 4. Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.
            node = "price";
            decimal maxPrice = 20.0m;

            Console.WriteLine("4. Removing elements from catalogue.xml...");
            DomParser.DeleteAlbumFromXmlBasedOnPrice(CataloguePath, node, maxPrice);
            Console.WriteLine("catalogueModified.xml created!");

            Console.WriteLine();

            // 5. Write a program, which using XmlReader extracts all song titles from catalog.xml.
            node = "title";
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("5. Songs extracted using XmlReader: ");
            Console.WriteLine(new string('-', 40));
            SongExtractor.ExtractSongsUsingXmlReader(CataloguePath, node);

            Console.WriteLine();

            // 6. Rewrite the same using XDocument and LINQ query.
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("6. Songs extracted using XDocument: ");
            Console.WriteLine(new string('-', 40));
            SongExtractor.ExtractSongsUsingXDocument(CataloguePath, node);

            Console.WriteLine();

            // 7. In a text file we are given the name, address and phone number of given person (each at a single line).
            // Write a program, which creates new XML document, which contains these data in structured XML format.
            string personInfoPath = "../../PersonInfo.txt";

            Console.WriteLine("7. Converting text file to xml: ");
            TextConvertor.ConvertTxtToXml(personInfoPath);

            Console.WriteLine();

            // 8. Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the
            // file album.xml, in which stores in appropriate way the names of all albums and their authors.

            Console.WriteLine("8. Reading albums and artists from XML and creating a new XML file.");
            var artistsAndAlbums = XmlExtractor.ReadArtistsAndAlbumsFromXmlFile(CataloguePath);
            XmlExtractor.WriteAlbumAndArtistsToXmlFile(artistsAndAlbums);

            Console.WriteLine();

            // 9. Write a program to traverse given directory and write to a XML file its contents together 
            //with all subdirectories and files. Use tags < file > and < dir > with appropriate attributes.
            //For the generation of the XML document use the class XmlWriter.

            string dirPath = "../../";
            Console.WriteLine("9. Traversing directory using XMLWriter and saving its content to XML file.");
            DirectoryTraverser.TraverseDirectoryUsingXmlWriter(dirPath);

            Console.WriteLine();

            // 10. Rewrite the last exercises using XDocument, XElement and XAttribute.
            Console.WriteLine("10. Traversing directory using XDocument and saving its content to XML file.");
            DirectoryTraverser.TraverseDirectoryUsingXDocument(dirPath);

            Console.WriteLine();

            // 11. Write a program, which extract from the file catalog.xml the prices for all albums, 
            //published 5 years ago or earlier. Use XPath query.
            Console.WriteLine("11. Extract album prices based on published year using XPath query.");

            pathQuery = "/catalogue/album";

            AlbumExtractor.ExtractPricesBasedOnPublishYearXPath(CataloguePath, pathQuery);

            Console.WriteLine();

            // 12. Rewrite the previous using LINQ query.
            Console.WriteLine("12. Extract album prices based on published year using LINQ query.");

            AlbumExtractor.ExtractPricesBasedOnPublishYearLinq(CataloguePath);

            Console.WriteLine();

            // 13. Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, 
            // formatted for viewing in a standard Web-browser.

            // 14. Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml 
            // using the class XslTransform.

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalogue.xslt");
            xslt.Transform(CataloguePath, "../../catalogue.html");

            // 16. Using Visual Studio generate an XSD schema for the file catalog.xml.
            // Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against 
            // the schema. Test it with valid XML catalogs and invalid XML catalogs.

            Console.WriteLine("16. Validating Schema");
            SchemaValidator.ValidateSchema(CataloguePath);
        }
    }
}