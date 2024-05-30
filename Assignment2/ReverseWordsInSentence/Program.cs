using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = "C# is not C++, and PHP is not Delphi!";

            string reversedSentence = ReverseWords(input);

            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedSentence);
        }

        static string ReverseWords(string sentence)
        {
         
            char[] separators = new char[] { ' ', '.', ',', ';', ':', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', '=' };
            
            List<string> wordsAndSeparators = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in sentence)
            {
                if (Array.IndexOf(separators, c) >= 0)
                {
                    if (sb.Length > 0)
                    {
                        wordsAndSeparators.Add(sb.ToString());
                        sb.Clear();
                    }
                    wordsAndSeparators.Add(c.ToString());
                }
                else
                {
                    sb.Append(c);
                }
            }
            if (sb.Length > 0)
            {
                wordsAndSeparators.Add(sb.ToString());
            }

            List<string> words = new List<string>();
            foreach (string part in wordsAndSeparators)
            {
                if (Array.IndexOf(separators, part[0]) < 0)
                {
                    words.Add(part);
                }
            }

            words.Reverse();

            StringBuilder result = new StringBuilder();
            int wordIndex = 0;
            foreach (string part in wordsAndSeparators)
            {
                if (Array.IndexOf(separators, part[0]) >= 0)
                {
                    result.Append(part);
                }
                else
                {
                    result.Append(words[wordIndex]);
                    wordIndex++;
                }
            }

            return result.ToString();
        }
    }
}
