namespace SummerShopping
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceOfTowell = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double priceOfUmbrella = (priceOfTowell / 3) * 2;
            double priceOfShoes = (priceOfUmbrella / 100) * 75;
            double priceOfBag = ((priceOfShoes + priceOfTowell) / 3) * 1;

            double totalMoney = priceOfTowell + priceOfUmbrella + priceOfShoes + priceOfBag;
            totalMoney *= 1 - percentDiscount / 100.0;

            if (totalMoney <= budget)
            {
                Console.WriteLine($"Annie's sum is {totalMoney:f2} lv. She has {budget - totalMoney:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalMoney:F2} lv. She needs {totalMoney - budget:f2} lv. more.");
            }
        }
    }
}
