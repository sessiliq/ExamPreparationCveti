namespace Series
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSeries = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < countSeries; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (name == "Thrones")
                {
                    price /= 2;
                }
                else if (name == "Lucifer")
                {
                    price -= 0.4 * price;
                }
                else if (name == "Protector")
                {
                    price -= 0.3 * price;
                }
                else if (name == "TotalDrama")
                {
                    price -= 0.2 * price;
                }
                else if (name == "Area")
                {
                    price -= 0.1 * price;
                }

                totalPrice += price;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalPrice - budget:f2} lv. more to buy the series!");
            }
        }
    }
}
