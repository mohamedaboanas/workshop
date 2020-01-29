using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                Console.WriteLine(text);

            var words = text.Split(' ');
            var totalCharachter = 0;

            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharachter += word.Length + 1;

                if (totalCharachter > maxLength)
                    break;
            }
            return string.Join(" ", summaryWords) + ".....";
        }

    }
}
