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

            const string Xpath = "//li[@class='commits']"; // Trying select the class
            try
            {
                System.Collections.Generic.IEnumerable<HtmlNode> Nodes = HTMLDocument.DocumentNode.SelectNodes(Xpath).Descendants();
                string StringNodes = Nodes.ToString();
                Console.WriteLine(Nodes);
            }
            catch (Exception)
            {
                Console.WriteLine("Não conseguiu acessar o site ou chegar ao objeto da seleção");
            }
            Console.ReadLine();

            //WebUtility.HtmlDecode();

        }
    }
}
