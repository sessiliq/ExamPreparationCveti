namespace DartsTournament
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int firstScores = int.Parse(Console.ReadLine());

            int i = 0;
            while (true)
            {
                if (firstScores == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {i} moves!");
                    break;
                }

                string sector = Console.ReadLine();
                i++;

                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {i} moves!");
                    break;
                }

                int scores = int.Parse(Console.ReadLine());

                if (sector == "number section")
                {
                    firstScores -= scores;
                }
                else if (sector == "double ring")
                {
                    firstScores -= scores * 2;
                }
                else if (sector == "triple ring")
                {
                    firstScores -= scores * 3;
                }
                
                if (firstScores < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(firstScores)}.");
                    break;
                }                               
            }
        }
    }
}
