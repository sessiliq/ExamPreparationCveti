namespace MobileOperator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int countMonths = int.Parse(Console.ReadLine());

            double monthTax = 0;
            double internetTax = 0;

            if (time == "one")
            {
                if (typeContract == "Small")
                {
                    monthTax = 9.98;
                }
                else if (typeContract == "Middle")
                {
                    monthTax = 18.99;
                }
                else if (typeContract == "Large")
                {
                    monthTax = 25.98;
                }
                else if (typeContract == "ExtraLarge")
                {
                    monthTax = 35.99;
                }
            }
            else 
            {
                if (typeContract == "Small")
                {
                    monthTax = 8.58;
                }
                else if (typeContract == "Middle")
                {
                    monthTax = 17.09;
                }
                else if (typeContract == "Large")
                {
                    monthTax = 23.59;
                }
                else if (typeContract == "ExtraLarge")
                {
                    monthTax = 31.79;
                }
            }

            if (internet == "yes")
            {
                if (monthTax <= 10)
                {
                    internetTax = 5.5;
                }
                else if (monthTax <= 30)
                {
                    internetTax = 4.35;
                }
                else
                {
                    internetTax = 3.85;
                }
            }

            double totalTax = monthTax + internetTax;

            if (time == "two")
            {
                totalTax -= (totalTax / 100) * 3.75;
            }

            Console.WriteLine($"{totalTax * countMonths:F2} lv.");
        }
    }
}
