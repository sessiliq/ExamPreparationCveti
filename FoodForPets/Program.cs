namespace FoodForPets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            int eatenFromTheDog = 0;
            int eatenFromTheCat = 0;
            double eatenBiscuits = 0;
            

            for (int i = 1; i <= countDays; i++)
            {
                int eatenFromDogForTheDay = int.Parse(Console.ReadLine());
                int eatenFromCatForTheDay = int.Parse(Console.ReadLine());

                eatenFromTheDog += eatenFromDogForTheDay;
                eatenFromTheCat += eatenFromCatForTheDay;
                int eatenForTheDay = eatenFromDogForTheDay + eatenFromCatForTheDay;

                if (i % 3 == 0)
                {
                    eatenBiscuits += eatenForTheDay * 0.1;
                }
            }

            int totalEatenFood = eatenFromTheCat + eatenFromTheDog;
            double percentEatenFood = totalEatenFood * 100.0 / food;
            double percentEatenFromThaCat = eatenFromTheCat * 100.0 / totalEatenFood;
            double percentEatenFromTheDog = eatenFromTheDog * 100.0 / totalEatenFood;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBiscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFromTheDog:F2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFromThaCat:F2}% eaten from the cat.");
        }
    }
}
