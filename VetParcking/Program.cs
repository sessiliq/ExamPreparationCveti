namespace VetParcking
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());

            double parckingTax = 0;

            for (int day = 1; day <= countDays; day++)
            {
                double dailyParckingTax = 0;
                double hourParckingTax = 0;

                for (int hour = 1; hour <= countHours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        hourParckingTax = 2.5;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        hourParckingTax = 1.25;
                    }
                    else
                    {
                        hourParckingTax = 1;
                    }

                    dailyParckingTax += hourParckingTax;
                }

                parckingTax += dailyParckingTax;

                Console.WriteLine($"Day: {day} - {dailyParckingTax:F2} leva");
            }

            Console.WriteLine($"Total: {parckingTax:F2} leva");
        }
    }
}
