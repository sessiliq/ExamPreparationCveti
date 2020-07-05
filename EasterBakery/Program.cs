namespace EasterBakery
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double priceKgFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int countPacksEgs = int.Parse(Console.ReadLine());
            int countPacksMay = int.Parse(Console.ReadLine());

            double priceSugar = priceKgFlour * 0.75;

            double moneyFlour = priceKgFlour * kgFlour;
            double moneySugar = priceSugar * kgSugar;
            double moneyEgs = (priceKgFlour * 1.1) * countPacksEgs;
            double moneyMay = (priceSugar * 0.2) * countPacksMay;

            double totalMoney = moneyFlour + moneySugar + moneyEgs + moneyMay;

            Console.WriteLine($"{totalMoney:F2}");
        }
    }
}
