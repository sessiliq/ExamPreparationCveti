namespace FitnessCard
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            if (sport == "Gym")
            {
                if (gender == "m")
                {
                    price = 42;
                }
                else
                {
                    price = 35;
                }
            }
            else if (sport == "Boxing")
            {
                if (gender == "m")
                {
                    price = 41;
                }
                else
                {
                    price = 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (gender == "m")
                {
                    price = 45;
                }
                else
                {
                    price = 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (gender == "m")
                {
                    price = 34;
                }
                else
                {
                    price = 31;
                }
            }
            else if (sport == "Dances")
            {
                if (gender == "m")
                {
                    price = 51;
                }
                else
                {
                    price = 53;
                }
            }
            else
            {
                if (gender == "m")
                {
                    price = 39;
                }
                else
                {
                    price = 37; 
                }
            }

            if (age <= 19)
            {
                price *= 1 - 0.2;
            }

            if (price <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price - budget:F2} more.");
            }
        }
    }
}
