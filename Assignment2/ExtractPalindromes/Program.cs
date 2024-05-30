using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 示例输入文本，可以根据需要修改
            string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

            // 提取回文并排序
            List<string> palindromes = ExtractAndSortPalindromes(input);

            // 输出结果
            Console.WriteLine("Palindromes:");
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static List<string> ExtractAndSortPalindromes(string text)
        {
            // 使用正则表达式匹配单词
            MatchCollection matches = Regex.Matches(text, @"\b\w+\b");

            // 使用 HashSet 来存储唯一的回文
            HashSet<string> uniquePalindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (Match match in matches)
            {
                string word = match.Value;
                if (IsPalindrome(word))
                {
                    uniquePalindromes.Add(word);
                }
            }

            // 将回文转换为列表并排序
            List<string> sortedPalindromes = uniquePalindromes.ToList();
            sortedPalindromes.Sort(StringComparer.OrdinalIgnoreCase);

            return sortedPalindromes;
        }

        static bool IsPalindrome(string word)
        {
            int len = word.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (char.ToLower(word[i]) != char.ToLower(word[len - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}