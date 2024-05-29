using System;

namespace GuessNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int correctNumber = new Random().Next(3) + 1;

            Console.WriteLine("Guess the number between 1 and 3:");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int guessedNumber))
            {

                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Your guess is out of the valid range. Please guess a number between 1 and 3.");
                }
                else
                {

                    if (guessedNumber < correctNumber)
                    {
                        Console.WriteLine("Your guess is low.");
                    }
                    else if (guessedNumber > correctNumber)
                    {
                        Console.WriteLine("Your guess is high.");
                    }
                    else
                    {
                        Console.WriteLine("Correct! You guessed the number.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer number.");
            }
        }
    }
}