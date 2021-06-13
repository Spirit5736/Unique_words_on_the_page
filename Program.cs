using System;

namespace Unique_words_on_the_page
{
    class Program
    {
        static void Main(string[] args)
        {
            HTMLQueryProcessing hTMLQueryProcessing = new HTMLQueryProcessing();
            hTMLQueryProcessing.TextProcessing(WebReader.DownloadString("https://www.simbirsoft.com/"));
        }
    }
}
