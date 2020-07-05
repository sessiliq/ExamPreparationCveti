namespace Shopping
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countVideocards = int.Parse(Console.ReadLine());
            int countProccesors = int.Parse(Console.ReadLine());
            int countRamMemory = int.Parse(Console.ReadLine());

            double videocardPrise = countVideocards * 250;
            double proccesorPrise = (35 / 100.0 * videocardPrise) * countProccesors;
            double ramMemoryPrise = (10 / 100.0 * videocardPrise) * countRamMemory;
            
            double totalPrise = videocardPrise + proccesorPrise + ramMemoryPrise;

            if (countVideocards > countProccesors)
            {
                totalPrise -= (15 / 100.0 * totalPrise);
            }

            if (totalPrise <= budget)
            {
                Console.WriteLine($"You have {budget - totalPrise:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrise - budget:f2} leva more!");
            }
        }
    }
}
