namespace Darts
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int firstScores = 301;
            int successfulShot = 0;
            int unsuccessfulShot = 0;

            while (true)
            {
                while (true)
                {
                    string type = Console.ReadLine();

                    if (type == "Retire")
                    {
                        Console.WriteLine($"{name} retired after {unsuccessfulShot} unsuccessful shots.");
                        return;
                    }

                    int points = int.Parse(Console.ReadLine());
                    int score = 0;

                    if (type == "Single")
                    {
                        score = points;

                    }
                    else if (type == "Double")
                    {
                        score = points * 2;

                    }
                    else if (type == "Triple")
                    {
                        score = points * 3;

                    }

                    if (score > firstScores)
                    {
                        unsuccessfulShot++;
                        break;
                    }
                    else
                    {
                        firstScores -= score;
                        successfulShot++;
                    }

                    if (firstScores == 0)
                    {
                        Console.WriteLine($"{name} won the leg with {successfulShot} shots.");
                        return;
                    }

                }
            }
        }
    }
}
