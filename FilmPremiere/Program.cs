namespace FilmPremiere
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFilm = Console.ReadLine();
            string pack = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (nameOfFilm == "John Wick")
            {
                if (pack == "Drink")
                {
                    price = 12 * countTickets;
                }
                else if (pack == "Popcorn")
                {
                    price = 15 * countTickets;
                }
                else if (pack == "Menu")
                {
                    price = 19 * countTickets;
                }
            }
            else if (nameOfFilm == "Star Wars")
            {
                if (pack == "Drink")
                {
                    price = 18 * countTickets;
                }
                else if (pack == "Popcorn")
                {
                    price = 25 * countTickets;
                }
                else if (pack == "Menu")
                {
                    price = 30 * countTickets;
                }

                if (countTickets >= 4)
                {
                    price -= 0.3 * price;
                }
            }
            else if (nameOfFilm == "Jumanji")
            {

                if (pack == "Drink")
                {
                    price = 9 * countTickets;
                }
                else if (pack == "Popcorn")
                {
                    price = 11 * countTickets;
                }
                else if (pack == "Menu")
                {
                    price = 14 * countTickets;
                }

                if (countTickets == 2)
                {
                    price -= 0.15 * price;
                }
            }

            Console.WriteLine($"Your bill is {price:F2} leva.");
        }
    }
}
