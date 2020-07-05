namespace EasterLunch
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countCakes = int.Parse(Console.ReadLine());
            int packsEgs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            double priceColorEgs = (packsEgs * 12) * 0.15;
            double priceCakes = countCakes * 3.2;
            double priceEgs = packsEgs * 4.35;
            double priceCookies = kgCookies * 5.4;

            double totalPrice = priceColorEgs + priceCakes + priceEgs + priceCookies;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
