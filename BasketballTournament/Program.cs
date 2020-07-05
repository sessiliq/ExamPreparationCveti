namespace BasketballTournament
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int matchesWon = 0;
            int matchesLost = 0;

            while (true)
            {
                string tournamentName = Console.ReadLine();
                int countGames = int.Parse(Console.ReadLine());

                for (int i = 1; i <= countGames; i++)
                {
                    int ourPoints = int.Parse(Console.ReadLine());
                    int theirPoints = int.Parse(Console.ReadLine());

                    if (ourPoints > theirPoints)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {ourPoints - theirPoints} points.");
                        matchesWon++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {theirPoints - ourPoints} points.");
                    }

                }
            }
        }
    }
}
