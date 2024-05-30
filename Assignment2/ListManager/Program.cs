using System;
using System.Collections.Generic;

namespace ListManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> itemList = new List<string>();

            while (true)
            {
               
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine();
                if (input.StartsWith("+ "))
                {
                    string itemToAdd = input.Substring(2).Trim();
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
                else if (input.StartsWith("- "))
                {
                    string itemToRemove = input.Substring(2).Trim();
                    if (itemList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {itemToRemove}");
                    }
                }
                else if (input == "--")
                {
                    itemList.Clear();
                    Console.WriteLine("List cleared.");
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
                
                Console.WriteLine("Current list:");
                foreach (string item in itemList)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine();
                Console.WriteLine(); 
            }
        }
    }
}