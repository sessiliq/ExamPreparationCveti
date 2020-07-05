namespace WorldSnookerChampionship
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string stageOfChampionhsip = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            string photo = Console.ReadLine();

            double ticketPrice = 0;

            if (stageOfChampionhsip == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 55.5;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 105.2;
                }
                else
                {
                    ticketPrice = 118.9;
                }
            }
            else if (stageOfChampionhsip == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 75.88;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 125.22;
                }
                else
                {
                    ticketPrice = 300.4;
                }
            }
            else if (stageOfChampionhsip == "Final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = 110.1;
                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = 160.66;
                }
                else
                {
                    ticketPrice = 400;
                }
            }

            double totalPrice = countOfTickets * ticketPrice;
            int photoPrice = 40 * countOfTickets;

            if (totalPrice > 4000)
            {
                if (photo == "Y")
                {
                    photoPrice = 0;
                    totalPrice -= totalPrice / 100.0 * 25;
                }
                else
                {
                    totalPrice -= totalPrice / 100.0 * 25;
                }
            }
            else if (totalPrice >= 2500)
            {
                totalPrice -= totalPrice / 100.0 * 10;
            }

            if (photo == "Y")
            {
                totalPrice += photoPrice;
            }

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
