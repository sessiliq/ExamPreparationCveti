namespace CinemaVoucher
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            int moneyLeft = voucher;
            int countTickets = 0;
            int countProducts = 0;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    Console.WriteLine(countTickets);
                    Console.WriteLine(countProducts);
                    break;
                }

                int prise = 0;

                if (product.Length > 8)
                {
                    prise = product[0] + product[1];

                    if (prise > moneyLeft)
                    {
                        Console.WriteLine(countTickets);
                        Console.WriteLine(countProducts);
                        break;
                    }
                    else
                    {
                        moneyLeft -= prise;
                    }

                    countTickets++;

                }
                else
                {
                    prise = product[0];

                    if (prise > moneyLeft)
                    {
                        Console.WriteLine(countTickets);
                        Console.WriteLine(countProducts);
                        break;
                    }
                    else
                    {
                        moneyLeft -= prise;
                    }

                    countProducts++;
                }
            }
        }
    }
}
