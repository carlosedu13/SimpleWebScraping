using System;
using System.Net;
using HtmlAgilityPack;

namespace WebScrappingGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "https://github.com/carlosedu13/LandingCurriculum";
            WebClient LocalWebClient = new WebClient();
            string Page = LocalWebClient.DownloadString(url);

            HtmlDocument HTMLDocument = new HtmlDocument();
            HTMLDocument.LoadHtml(Page);

            const string Xpath = "//div[contains(@class, 'content')"; // Trying select the class
            var Nodes = HTMLDocument.DocumentNode.SelectNodes(Xpath);
            Console.WriteLine(Nodes);
            //.Descendants().First(x => x.attributes["class"] != null && x.Attributes["class"].Value.Equals("overall")).InnerText;
            //WebUtility.HtmlDecode();
            
        }
    }
}
