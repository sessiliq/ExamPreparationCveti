namespace TouristShop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double price = 0;
            int countProducts = 0;
            double moneyLeft = budget;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "Stop")
                {
                    Console.WriteLine($"You bought {countProducts} products for {price:F2} leva.");
                    break;
                }
                countProducts++;

                double productPrice = double.Parse(Console.ReadLine());

                if (countProducts % 3 == 0)
                {
                    productPrice /= 2;
                }

                price += productPrice;

                if (productPrice > moneyLeft)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need { productPrice - moneyLeft:F2} leva!");
                    break;
                }

                moneyLeft -= productPrice;
            }
        }
    }
}
