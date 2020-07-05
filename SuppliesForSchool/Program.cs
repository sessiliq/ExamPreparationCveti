namespace SuppliesForSchool
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfPens = int.Parse(Console.ReadLine());
            int countOfMarkers = int.Parse(Console.ReadLine());
            double litterPreparations = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double moneyForPens = countOfPens * 5.8;
            double moneyForMarkers = countOfMarkers * 7.2;
            double moneyForLitterPreparations = litterPreparations * 1.2;

            double totalNeededMoney = moneyForPens + moneyForMarkers + moneyForLitterPreparations;
            totalNeededMoney = totalNeededMoney * (1 - (discount / 100.0)); 

            Console.WriteLine($"{totalNeededMoney:F3}");
        }
    }
}
