namespace EasterParty
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            double priceEnvelope = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget / 100 * 10;

            if (countGuests >= 10 && countGuests <= 15)
            {
                priceEnvelope *= 1 - 0.15;
            }
            else if (countGuests > 15 && countGuests <= 20)
            {
                priceEnvelope *= 1 - 0.2;
            }
            else if (countGuests > 20)
            {
                priceEnvelope *= 1 - 0.25;
            }
            
            double moneyNeeded = (priceEnvelope * countGuests) + cakePrice;

            if (moneyNeeded <= budget)
            {
                Console.WriteLine($"It is party time! {budget - moneyNeeded:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {moneyNeeded - budget:F2} leva needed.");
            }
        }
    }
}
