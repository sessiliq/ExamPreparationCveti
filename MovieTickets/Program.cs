namespace MovieTickets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            char symbol1 = ' ';
            int symbol2 = 0;
            int symbol3 = 0;
            int symbol4 = 0;

            for (int i = a1; i <= a2 - 1; i++)
            {
                if (i % 2 != 0)
                {
                    symbol1 = (char)i;

                    for (int j = 1; j < number; j++)
                    {
                        symbol2 = j;

                        for (int k = 1; k <= number / 2 - 1; k++)
                        {
                            symbol3 = k;
                            symbol4 = i;

                            if ((symbol2 + symbol3 + symbol4) % 2 != 0)
                            {
                                Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{symbol4}");
                               
                            }



                        }
                    }
                }
            }
        }
    }
}
