using System;

namespace ArrayCopyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] originalArray = new int[10];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = i + 1; 
            }

           
            int[] copiedArray = new int[originalArray.Length];
            
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array:");
            PrintArray(originalArray);
            Console.WriteLine("Copied Array:");
            PrintArray(copiedArray);
        }


        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}