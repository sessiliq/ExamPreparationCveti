namespace LunchBreak
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int timeForEpisod = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8.0;
            double freeTime = breakTime / 4.0;
            double timeLeft = breakTime - lunchTime - freeTime;

            if (timeLeft >= timeForEpisod)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(timeLeft - timeForEpisod)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(timeForEpisod - timeLeft)} more minutes.");
            }
        }
    }
}
