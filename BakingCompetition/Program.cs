namespace BakingCompetition
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfCookers = int.Parse(Console.ReadLine());

            int totalBakedCookies = 0;
            int totalBakedCakes = 0;
            int totalBakesWaffles = 0;

            for (int i = 0; i < countOfCookers; i++)
            {
                string name = Console.ReadLine();

                int countCookies = 0;
                int countCakes = 0;
                int countWaffles = 0;

                while (true)
                {
                    string cakeType = Console.ReadLine();

                    if (cakeType == "Stop baking!")
                    {
                        Console.WriteLine($"{name} baked {countCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");
                        break;
                    }

                    int bakedCakes = int.Parse(Console.ReadLine());

                    if (cakeType == "cookies")
                    {
                        countCookies += bakedCakes;
                        totalBakedCookies += bakedCakes;
                    }
                    else if (cakeType == "cakes")
                    {
                        countCakes += bakedCakes;
                        totalBakedCakes += bakedCakes;
                    }
                    else if (cakeType == "waffles")
                    {
                        countWaffles += bakedCakes;
                        totalBakesWaffles += bakedCakes;
                    }
                }
            }
            double totalMoney = totalBakedCookies * 1.5 + totalBakedCakes * 7.8 + totalBakesWaffles * 2.3;

            Console.WriteLine($"All bakery sold: {totalBakedCookies + totalBakedCakes + totalBakesWaffles}");
            Console.WriteLine($"Total sum for charity: {totalMoney:F2} lv.");
        }
    }
}
