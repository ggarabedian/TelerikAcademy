namespace ProcessingJsonInDotNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class ProcessingJsonTasker
    {
        public static JObject DownloadRssFeedAsJson()
        {
            var webClient = new WebClient();

            var data = webClient.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");

            var xmlContent = Encoding.UTF8.GetString(data);
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            var jsonDoc = JsonConvert.SerializeXmlNode(xmlDoc, Newtonsoft.Json.Formatting.Indented);

            var jsonContent = JObject.Parse(jsonDoc);

            return jsonContent;
        }

        public static void ExtractAndPrintVideoTitles(JObject jsonContent)
        {
            var videoTitles = jsonContent["feed"]["entry"]
                .Select(entry => entry["title"]);

            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }
        }

        public static IEnumerable<Video> ParseJsonToPoco(JObject jsonContent)
        {
            var videos = jsonContent["feed"]["entry"]
                .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return videos;
        }

        public static string CreateHtmlContent(IEnumerable<Video> videos)
        {
            var html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><style>ul{list-style-type: none;}</style><body><ul>");

            foreach (var video in videos)
            {
                html.AppendFormat("<li><div><h2>{2}<h2></div><iframe src =\"http://www.youtube.com/embed/{0}?autoplay=0\"></iframe><div><a href=\"{1}\">Watch On YouTube!<a/></div></li>", video.Id, video.Link.Href, video.Title);
            }

            return html.ToString();
        }

        public static void WriteHtmlToFile(string html, string htmlFileName)
        {
            using (StreamWriter writer = new StreamWriter(htmlFileName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }
        }
    }
}
