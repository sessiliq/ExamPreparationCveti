namespace CruiseGames
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string playersName = Console.ReadLine();
            int countGames = int.Parse(Console.ReadLine());

            double volleyballScore = 0;
            double tennisScore = 0;
            double badmintonScore = 0;

            int countVolleybalGames = 0;
            int countTennisGames = 0;
            int countBadmintonGames = 0;                      

            for (int i = 0; i < countGames; i++)
            {
                string game = Console.ReadLine();
                double score = int.Parse(Console.ReadLine());

                if (game == "volleyball")
                {
                    score *= 1 + 0.07;
                    volleyballScore += score;
                    countVolleybalGames++;
                }
                else if (game == "tennis")
                {
                    score *= 1 + 0.05;
                    tennisScore += score;
                    countTennisGames++;
                }
                else if (game == "badminton")
                {
                    score *= 1 + 0.02;
                    badmintonScore += score;
                    countBadmintonGames++;
                }                
            }

            double totalScore = volleyballScore + tennisScore + badmintonScore; ;

            double mediumScoresVolleyball = Math.Floor(volleyballScore / countVolleybalGames);
            double mediumScoresTennis = Math.Floor(tennisScore / countTennisGames);
            double mediumScoresBadminton = Math.Floor(badmintonScore / countBadmintonGames);

            if (mediumScoresVolleyball >= 75 && mediumScoresTennis >= 75 && mediumScoresBadminton >= 75)
            {
                Console.WriteLine($"Congratulations, {playersName}! You won the cruise games with {Math.Floor(totalScore)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playersName}, you lost. Your points are only {Math.Floor(totalScore)}.");
            }         

        }
    }
}
