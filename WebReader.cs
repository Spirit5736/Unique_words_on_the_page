using HtmlAgilityPack;




namespace Unique_words_on_the_page
{
    public class WebReader
    {
        public static string DownloadString(string html)
        {    
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(html);
            var htmlNode = doc.DocumentNode.SelectSingleNode("//div/main");
            string textFromNode = htmlNode.InnerText;
            return textFromNode;
        }
    }
}
