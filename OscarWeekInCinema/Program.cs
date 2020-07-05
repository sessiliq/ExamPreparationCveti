namespace OscarWeekInCinema
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double income = 0;

            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    income = 7.5 * countTickets;
                }
                else if (hallType == "luxury")
                {
                    income = 10.5 * countTickets;
                }
                else if (hallType == "ultra luxury")
                {
                    income = 13.5 * countTickets;
                }
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    income = 7.35 * countTickets;
                }
                else if (hallType == "luxury")
                {
                    income = 9.45 * countTickets;
                }
                else if (hallType == "ultra luxury")
                {
                    income = 12.75 * countTickets;
                }
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal")
                {
                    income = 8.15 * countTickets;
                }
                else if (hallType == "luxury")
                {
                    income = 10.25 * countTickets;
                }
                else if (hallType == "ultra luxury")
                {
                    income = 13.25 * countTickets;
                }
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal")
                {
                    income = 8.75 * countTickets;
                }
                else if (hallType == "luxury")
                {
                    income = 11.55 * countTickets;
                }
                else if (hallType == "ultra luxury")
                {
                    income = 13.95 * countTickets;
                }
            }

            Console.WriteLine($"{movieName} -> {income:F2} lv.");
        }
    }
}
