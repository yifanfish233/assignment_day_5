using System;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // 示例输入，可以根据需要修改
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            // 找到最长连续相等元素序列
            int[] longestSequence = FindLongestSequence(array);

            // 输出结果
            Console.WriteLine("Longest sequence of equal elements:");
            Console.WriteLine(string.Join(" ", longestSequence));
        }

        static int[] FindLongestSequence(int[] array)
        {
            int maxLength = 1;
            int currentLength = 1;
            int element = array[0];
            int startIndex = 0;
            int bestStartIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        bestStartIndex = startIndex;
                    }
                    currentLength = 1;
                    startIndex = i;
                }
            }

            // 检查最后一个序列
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestStartIndex = startIndex;
            }

            int[] longestSequence = new int[maxLength];
            Array.Copy(array, bestStartIndex, longestSequence, 0, maxLength);
            return longestSequence;
        }
    }
}