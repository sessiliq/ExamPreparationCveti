namespace ChristmasTournament
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            int totalWonGames = 0;
            int totalLostGames = 0;
            double totalMoney = 0;

            for (int i = 0; i < tournamentDays; i++)
            {
                double wonMoney = 0;
                int wonGames = 0;
                int lostGames = 0;

                while (true)
                {
                    string sport = Console.ReadLine();

                    if (sport == "Finish")
                    {
                        if (wonGames > lostGames)
                        {
                            wonMoney *= 1 + 0.1;
                        }

                        break;
                    }

                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        wonMoney += 20;
                        wonGames++;
                    }
                    else
                    {
                        lostGames++;
                    }
                }
                totalMoney += wonMoney;
                totalWonGames += wonGames;
                totalLostGames += lostGames;
            }

            if (totalWonGames > totalLostGames)
            {
                totalMoney *= 1 + 0.2;

                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
            }
        }
    }
}
