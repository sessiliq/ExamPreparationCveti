namespace FoodDelivery
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegeterianMenuCount = int.Parse(Console.ReadLine());

            double menuPrice = chickenMenuCount * 10.35 + fishMenuCount * 12.4 + vegeterianMenuCount * 8.15;
            double desertPrice = (menuPrice / 100) * 20;

            double totalPrice = menuPrice + desertPrice + 2.5;

            Console.WriteLine("Total: {0:F2}", totalPrice);
        }
    }
}
