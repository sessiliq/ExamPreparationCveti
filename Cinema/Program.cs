namespace Cinema
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            int totalCountOfPeople = 0;
            int income = 0;
            int seatsLeft = capacity;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Movie time!")
                {
                    Console.WriteLine($"There are {capacity - totalCountOfPeople} seats left in the cinema.");
                    break;
                }

                int countOfPeople = int.Parse(command);
                totalCountOfPeople += countOfPeople;

                if (countOfPeople > seatsLeft)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }
                seatsLeft -= countOfPeople;

                if (countOfPeople % 3 == 0)
                {
                    income += (countOfPeople * 5) - 5;
                }
                else
                {
                    income += countOfPeople * 5;
                }
            }

            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
