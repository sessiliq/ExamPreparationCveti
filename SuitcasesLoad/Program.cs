namespace SuitcasesLoad
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            int suitcasesCount = 0;
            double spaceLeft = capacity;

            int i = 1;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }

                double suitcaseSize = double.Parse(command);

                if (i % 3 == 0)
                {
                    suitcaseSize *= 1 + 0.1;
                }

                spaceLeft -= suitcaseSize;
                if (spaceLeft < 0)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                suitcasesCount++;

                i++;
            }

            Console.WriteLine($"Statistic: {suitcasesCount} suitcases loaded.");
        }
    }
}
