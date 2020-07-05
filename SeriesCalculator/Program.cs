namespace SeriesCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int countSeasons = int.Parse(Console.ReadLine());
            int countSeriesPerSeason = int.Parse(Console.ReadLine());
            double timeForEpisod = double.Parse(Console.ReadLine());

            double addTime = 20 / 100.0 * timeForEpisod;
            double timeSeriesWithAdd = timeForEpisod + addTime;
            double timeSpecialSeries = countSeasons * 10;
            double totalTime = (timeSeriesWithAdd * countSeriesPerSeason * countSeasons) + timeSpecialSeries;
           
            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {Math.Floor(totalTime)} minutes.");
 
        }
    }
}
