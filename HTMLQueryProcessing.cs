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
            var groupedArray = words.GroupBy(i => i).ToList();
            groupedArray.ForEach(word => Console.WriteLine($"{word.Key} - {word.Count()}"));           
            }        
        }
}
