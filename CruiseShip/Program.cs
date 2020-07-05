namespace CruiseShip
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string cruisePlace = Console.ReadLine();
            string roomType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (cruisePlace == "Mediterranean")
            {
                if (roomType == "standard cabin")
                {
                    totalPrice = 4 * 27.50 * days;
                }
                else if (roomType == "cabin with balcony")
                {
                    totalPrice = 4 * 30.2 * days;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = 4 * 40.5 * days;
                }
            }
            else if (cruisePlace == "Adriatic")
            {
                if (roomType == "standard cabin")
                {
                    totalPrice = 4 * 22.99 * days;
                }
                else if (roomType == "cabin with balcony")
                {
                    totalPrice = 4 * 25 * days;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = 4 * 34.99 * days;
                }
            }
            else if (cruisePlace == "Aegean")
            {
                if (roomType == "standard cabin")
                {
                    totalPrice = 4 * 23 * days;
                }
                else if (roomType == "cabin with balcony")
                {
                    totalPrice = 4 * 26.6 * days;
                }
                else if (roomType == "apartment")
                {
                    totalPrice = 4 * 39.8 * days;
                }
            }

            if (days > 7)
            {
                totalPrice *= 1 - 0.25;
            }

            Console.WriteLine($"Annie's holiday in the {cruisePlace} sea costs {totalPrice:F2} lv.");
        }
    }
}
