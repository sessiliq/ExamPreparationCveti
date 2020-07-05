namespace CareForThePuppy
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int foodKg = int.Parse(Console.ReadLine());
            int foodGrams = foodKg * 1000;
            int eatenFood = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }

                eatenFood += int.Parse(command);
            }

            if (eatenFood <= foodGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodGrams - eatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatenFood - foodGrams} grams more.");
            }
        }
    }
}
