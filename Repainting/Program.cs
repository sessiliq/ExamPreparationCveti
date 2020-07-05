namespace Repainting
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int nylonNeeded = int.Parse(Console.ReadLine());
            int paintNeeded = int.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonPrise = (nylonNeeded + 2) * 1.5;
            double paintPrise = ((paintNeeded / 100.0 * 10) + paintNeeded) * 14.5;
            double thinnerPrise = thinnerNeeded * 5;
            double totalPrise = nylonPrise + paintPrise + thinnerPrise + 0.4;
            double prisePerHour = totalPrise / 100.0 * 30;
            double priseWork = prisePerHour * hoursNeeded;
            totalPrise += priseWork;

            Console.WriteLine($"Total expenses: {totalPrise:F2} lv.");
        }
    }
}
