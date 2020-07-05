namespace DivisionWithoutReminder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double countNumbers = double.Parse(Console.ReadLine());

            double countWithoutReminder2 = 0;
            double countWithoutReminder4 = 0;
            double countWithoutReminder3 = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countWithoutReminder2++;
                }
                if (number % 3 == 0)
                {
                    countWithoutReminder3++;
                }
                if (number % 4 == 0)
                {
                    countWithoutReminder4++;
                }
            }

            double percentWithoutReminder2 = countWithoutReminder2 / countNumbers * 100.0;
            double percentWithoutReminder3 = countWithoutReminder3 / countNumbers * 100.0;
            double percentWithoutReminder4 = countWithoutReminder4 / countNumbers * 100.0;

            Console.WriteLine($"{percentWithoutReminder2:F2}%");
            Console.WriteLine($"{percentWithoutReminder3:F2}%");
            Console.WriteLine($"{percentWithoutReminder4:F2}%");


        }
    }
}
