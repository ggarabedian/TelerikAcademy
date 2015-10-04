namespace ProcessingJsonInDotNet
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            const string HtmlFileName = "../../index.html";

            Console.OutputEncoding = Encoding.UTF8;

            var jsonContent = ProcessingJsonTasker.DownloadRssFeedAsJson();

            ProcessingJsonTasker.ExtractAndPrintVideoTitles(jsonContent);

            var videos = ProcessingJsonTasker.ParseJsonToPoco(jsonContent);

            var html = ProcessingJsonTasker.CreateHtmlContent(videos);

            ProcessingJsonTasker.WriteHtmlToFile(html, HtmlFileName);
        }
    }
}
