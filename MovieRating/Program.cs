namespace MovieRating
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countMovies = int.Parse(Console.ReadLine());

            double highestMovie = double.MinValue;
            double lowestMovie = double.MaxValue;
            string bestMovie = string.Empty;
            string worstMovie = string.Empty;
            double averageRating = 0;

            for (int i = 0; i < countMovies; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                averageRating += rating;

                if (rating >= highestMovie)
                {
                    highestMovie = rating;
                    bestMovie = movieName;
                }

                if (rating <= lowestMovie)
                {
                    lowestMovie = rating;
                    worstMovie = movieName;
                }

            }

            averageRating /= countMovies;

            Console.WriteLine($"{bestMovie} is with highest rating: {highestMovie:F1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {lowestMovie:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");
        }
    }
}
