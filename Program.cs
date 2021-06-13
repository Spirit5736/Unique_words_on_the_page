using System;

namespace Unique_words_on_the_page
{
    class Program
    {
        static void Main(string[] args)
        {
            //var htmlWeb = new HtmlWeb();
            //var doc = htmlWeb.Load("https://www.simbirsoft.com/");
            //var htmlNode = doc.DocumentNode.SelectSingleNode("//div/main");
            //string textFromNode = htmlNode.InnerText;


            //var htmlNodes = htmlWeb.DocumentNode.SelectNodes("p[@class='main-page-block']");

            //foreach (var htmlNode in htmlNodes)
            //{
            //Console.WriteLine(("https://www.simbirsoft.com/"));
            //}

            HTMLQueryProcessing hTMLQueryProcessing = new HTMLQueryProcessing();
            hTMLQueryProcessing.TextProcessing(WebReader.DownloadString("https://www.simbirsoft.com/"));
        }
    }
}
