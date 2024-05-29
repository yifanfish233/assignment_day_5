using System;

namespace BirthdayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1990, 5, 28); 

            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthDate;
            int ageInDays = ageSpan.Days;

            Console.WriteLine($"You are {ageInDays} days old.");
            
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);

            DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

            Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversaryDate.ToShortDateString()}.");
        }
    }
}