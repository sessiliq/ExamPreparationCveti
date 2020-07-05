namespace GodzillaVSKong
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countArtists = int.Parse(Console.ReadLine());
            double clothesPrise = double.Parse(Console.ReadLine());

            double dekorating = 10 / 100.0 * budget;
            double totalClothesPrise = clothesPrise * countArtists;

            if (countArtists > 150)
            {
                totalClothesPrise -= (10 / 100.0 * totalClothesPrise);
            }

            double totalPrise = totalClothesPrise + dekorating;

            if (budget >= totalPrise)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with { budget - totalPrise:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { totalPrise - budget:F2} leva more.");
            }
        }
    }
}
