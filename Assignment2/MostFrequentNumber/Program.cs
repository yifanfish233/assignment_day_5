using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int[] array = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10 };
            // int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
    
            List<int> mostFrequentNumbers = FindMostFrequentNumbers(array);


            if (mostFrequentNumbers.Count == 1)
            {
                Console.WriteLine($"The number {mostFrequentNumbers[0]} is the most frequent.");
            }
            else
            {
                Console.WriteLine($"The numbers {string.Join(", ", mostFrequentNumbers)} have the same maximal frequency.");
            }
        }

        static List<int> FindMostFrequentNumbers(int[] array)
        {
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            // 统计每个数字的频率
            foreach (int num in array)
            {
                if (frequencyDict.ContainsKey(num))
                {
                    frequencyDict[num]++;
                }
                else
                {
                    frequencyDict[num] = 1;
                }
            }


            int maxFrequency = frequencyDict.Values.Max();
            
            List<int> mostFrequentNumbers = frequencyDict
                .Where(pair => pair.Value == maxFrequency)
                .Select(pair => pair.Key)
                .ToList();

            return mostFrequentNumbers;
        }
    }
}