using System;

namespace Unique_words_on_the_page
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес страницы:");
            Console.Write("http://");
            string link = "http://" + Console.ReadLine();
            HTMLQueryProcessing hTMLQueryProcessing = new HTMLQueryProcessing();
            hTMLQueryProcessing.TextProcessing(WebReader.DownloadString(link));
        }
    }
}
