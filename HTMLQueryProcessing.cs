using System;
using System.Linq;

namespace Unique_words_on_the_page
{
    public class HTMLQueryProcessing
    {
        public void TextProcessing(string textFromNode)
        {            
            char[] delimiterChars = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\r', '\n', '\t', };            
            string[] words = textFromNode
                .Replace("\n", "")
                .Split(delimiterChars);            
            words = words.Where(w => w != null && w != "" && w != " ").ToArray();
            //
            var groupedarray = words.GroupBy(i => i);
            int c = 0;
            foreach (var word in groupedarray)
            {
                if (word.Count() == 1)
                {
                    c++;
                }
                else
                    Console.WriteLine(word.Key + " - " + word.Count());
            }            
            Console.ReadKey();

        }

        //public void СalculatingOfUniqueValuesInArray(string[] array)
        //{
        //    var a = string[] array;
        //}
    }
}
