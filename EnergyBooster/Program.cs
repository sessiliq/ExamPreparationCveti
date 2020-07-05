namespace EnergyBooster
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string packSize = Console.ReadLine();
            int countOfPacks = int.Parse(Console.ReadLine());

            double price = 0;
            
            if (fruit == "Watermelon")
            {
                if (packSize == "small")
                {
                    price = 56 * countOfPacks * 2;
                }
                else
                {
                    price = 28.70 * countOfPacks * 5;
                }
            }
            else if (fruit == "Mango")
            {
                if (packSize == "small")
                {
                    price = 36.66 * countOfPacks * 2;
                }
                else
                {
                    price = 19.60 * countOfPacks * 5;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (packSize == "small")
                {
                    price = 42.10 * countOfPacks * 2;
                }
                else
                {
                    price = 24.80 * countOfPacks * 5;
                }
            }
            else 
            {
                if (packSize == "small")
                {
                    price = 20 * countOfPacks * 2;
                }
                else
                {
                    price = 15.20 * countOfPacks * 5;
                }
            }

            if (price >= 400 && price <= 1000)
            {
                price *= 1 - 0.15;
            }
            else if (price > 1000)
            {
                price *= 1 - 0.5;
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
