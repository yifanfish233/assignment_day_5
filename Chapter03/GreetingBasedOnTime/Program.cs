using System;

namespace GreetingBasedOnTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentTime = DateTime.Now;
            int currentHour = currentTime.Hour;
            
            if (currentHour >= 5 && currentHour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (currentHour >= 12 && currentHour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (currentHour >= 17 && currentHour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 5))
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}