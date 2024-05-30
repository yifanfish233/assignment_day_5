using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // version1
            string reversedStringByArray = ReverseStringUsingArray(input);
            Console.WriteLine("Reversed string using char array:");
            Console.WriteLine(reversedStringByArray);

            // version2
            string reversedStringByLoop = ReverseStringUsingLoop(input);
            Console.WriteLine("Reversed string using for loop:");
            Console.WriteLine(reversedStringByLoop);
        }

        // version1
        static string ReverseStringUsingArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // version2
        static string ReverseStringUsingLoop(string input)
        {
            string reversedString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            return reversedString;
        }
    }
}