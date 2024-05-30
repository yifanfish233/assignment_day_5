using System;
using System.Linq;

namespace ArrayRotationSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array elements (space-separated):");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Enter number of rotations:");
            int k = int.Parse(Console.ReadLine());
            int[] sumArray = new int[array.Length];
            for (int r = 1; r <= k; r++)
            {
                int[] rotatedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    int newPosition = (i + r) % array.Length;
                    rotatedArray[newPosition] = array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    sumArray[i] += rotatedArray[i];
                }
            }
            Console.WriteLine("Sum array after rotations:");
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}