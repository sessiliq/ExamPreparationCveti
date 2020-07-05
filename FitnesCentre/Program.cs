namespace FitnesCentre
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countClients = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < countClients; i++)
            {
                string activity = Console.ReadLine();

                if (activity == "Back")
                {
                    back++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                }
            }

            double percentWorkout = (back + chest + legs + abs) * 100.0 / countClients;
            double percentProtein = (proteinBar + proteinShake) * 100.0 / countClients;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentWorkout:F2}% - work out");
            Console.WriteLine($"{percentProtein:F2}% - protein");
        }
    }
}

