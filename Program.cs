using System;
using System.IO;

namespace Unique_words_on_the_page
{
    class Program
    {    
        static void Main(string[] args)
        {           
            try
            {
                Console.WriteLine("Введите адрес страницы:");
                Console.Write("http://");
                string link = "http://" + Console.ReadLine();
                HTMLQueryProcessing hTMLQueryProcessing = new HTMLQueryProcessing();
                hTMLQueryProcessing.TextProcessing(WebReader.DownloadString(link));
            }

            catch
            {
                Console.WriteLine("Не корректно введен адрес, работа приложена будет завершена.");
            }
        }
    }
}
