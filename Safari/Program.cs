namespace Safari
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double moneyForFuel = fuelNeeded * 2.1;
            double price = moneyForFuel + 100;

            if (day == "Saturday")
            {
                price -= (price / 100) * 10;
            }
            else
            {
                price -= (price / 100) * 20;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Safari time! Money left: {budget - price:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price - budget:F2} lv.");
            }
        }
    }
}
