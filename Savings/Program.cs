using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneyForNeeds = double.Parse(Console.ReadLine());

            double emergencySave = income / 100 * 30;
            double moneyLeft = income - moneyForNeeds - emergencySave;

            double percentSavedMoney = moneyLeft * 100.0 / income;
            double savedMoney = moneyLeft * months;

            Console.WriteLine($"She can save {percentSavedMoney:F2}%");
            Console.WriteLine($"{savedMoney:f2}");
        }
    }
}
