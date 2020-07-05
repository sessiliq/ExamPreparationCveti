namespace FavoriteMovie
{
    using System;
    using System.Drawing;

    class Program
    {
        static void Main(string[] args)
        {
            string bestMovie = string.Empty;
            int lastPoints = 0;

            int k = 0;
            while (true)
            {
                string nameOfMovie = Console.ReadLine();
                int totalPoints = 0;

                if (nameOfMovie == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {bestMovie} with {lastPoints} ASCII sum.");
                    break;
                }

                for (int i = 0; i < nameOfMovie.Length; i++)
                {
                    char letter = nameOfMovie[i];
                    int points = letter;


                    if (char.IsUpper(letter))
                    {
                        points -= nameOfMovie.Length;
                        totalPoints += points;
                    }
                    else if (char.IsLower(letter))
                    {
                        points -= nameOfMovie.Length * 2;
                        totalPoints += points;
                    }
                    else
                    {
                        points = letter;
                        totalPoints += points;
                    }
                }

                if (totalPoints > lastPoints)
                {
                    bestMovie = nameOfMovie;
                    lastPoints = totalPoints;
                }

                k++;

                if (k >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    Console.WriteLine($"The best movie for you is {bestMovie} with {lastPoints} ASCII sum.");
                    break;
                }
            }
        }
    }
}
