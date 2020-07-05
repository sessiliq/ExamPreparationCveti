namespace MountainRun
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsFor1meter = double.Parse(Console.ReadLine());

            double timeForDistance = distance * secondsFor1meter;
            double lostTime = Math.Floor(distance / 50);
            lostTime *= 30;
            double totalTime = timeForDistance + lostTime;

            if (totalTime >= worldRecord)
            {
                Console.WriteLine($"No! He was {totalTime - worldRecord:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
        }
    }
}
