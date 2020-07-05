namespace CinemaTickets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            double studentsTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;
            int totalTicketsSold = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                int freePlaces = int.Parse(Console.ReadLine());

                int ticketsSold = 0;

                int i = 0;
                while (true)
                {
                    double hall = ticketsSold * 100.0 / freePlaces;

                    if (i >= freePlaces)
                    {
                        Console.WriteLine($"{movieName} - {hall:f2}% full.");
                        break;
                    }

                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        Console.WriteLine($"{movieName} - {hall:f2}% full.");
                        break;
                    }

                    if (ticketType == "student")
                    {
                        studentsTickets++;
                        ticketsSold++;
                        totalTicketsSold++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                        ticketsSold++;
                        totalTicketsSold++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsTickets++;
                        ticketsSold++;
                        totalTicketsSold++;
                    }

                    i++;

                }
            }

            Console.WriteLine($"Total tickets: {totalTicketsSold}");
            Console.WriteLine($"{studentsTickets * 100 / totalTicketsSold:F2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100 / totalTicketsSold:F2}% standard tickets.");
            Console.WriteLine($"{kidsTickets * 100 / totalTicketsSold:f2}% kids tickets.");
        }
    }
}
