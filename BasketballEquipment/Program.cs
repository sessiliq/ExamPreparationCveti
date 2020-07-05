namespace BasketballEquipment
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double shoesPrice = yearTax - (yearTax / 100.0 * 40);
            double clothesPrice = shoesPrice - (shoesPrice / 100.0 * 20);
            double ballPrice = (clothesPrice / 4) * 1;
            double accesoriesPrice = (ballPrice / 5) * 1;

            double totalPrice = yearTax + shoesPrice + clothesPrice + ballPrice + accesoriesPrice;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
