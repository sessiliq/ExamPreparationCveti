namespace Skeleton
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int controlaMin = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secondsPer100M = int.Parse(Console.ReadLine());

            int controlaInSeconds = controlaMin * 60 + controlSeconds;

            double time = (length / 100) * secondsPer100M;
            double slowDown = length / 120 * 2.5;

            time -= slowDown;

            if (time <= controlaInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {time:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was { time - controlaInSeconds:F3} second slower.");
                
            }
        }
    }
}
