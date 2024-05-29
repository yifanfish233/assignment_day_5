using System;

namespace UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of centuries: ");
            if (int.TryParse(Console.ReadLine(), out int centuries))
            {
                // Constants for time conversions
                const int yearsInCentury = 100;
                const int daysInYear = 36524 / 100; // Average including leap years
                const int hoursInDay = 24;
                const int minutesInHour = 60;
                const int secondsInMinute = 60;
                const int millisecondsInSecond = 1000;
                const int microsecondsInMillisecond = 1000;
                const int nanosecondsInMicrosecond = 1000;

                // Calculating each unit
                long years = centuries * yearsInCentury;
                long days = years * daysInYear;
                long hours = days * hoursInDay;
                long minutes = hours * minutesInHour;
                long seconds = minutes * secondsInMinute;
                long milliseconds = seconds * millisecondsInSecond;
                long microseconds = milliseconds * microsecondsInMillisecond;
                decimal nanoseconds = microseconds * nanosecondsInMicrosecond;

                // Displaying the result
                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }
}