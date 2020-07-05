namespace OscarCeremony
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double prize = rent - (30 / 100.0 * rent);
            double food = prize - (15 / 100.0 * prize);
            double sound = food / 2.0;

            double prise = rent + prize + food + sound;

            Console.WriteLine($"{prise:F2}");
        }
    }
}
