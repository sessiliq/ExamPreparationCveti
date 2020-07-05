namespace TreckingMania
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfGrups = int.Parse(Console.ReadLine());

            int climbersMusala = 0;
            int climbersMonblan = 0;
            int climbersKilimanjaro = 0;
            int climbersK2 = 0;
            int climbersEverest = 0;
            int countOfClimbers = 0;

            for (int i = 0; i < countOfGrups; i++)
            {
                int peopleInGrup = int.Parse(Console.ReadLine());
                countOfClimbers += peopleInGrup;

                if (peopleInGrup <= 5)
                {
                    climbersMusala += peopleInGrup;
                }
                else if (peopleInGrup > 5 && peopleInGrup <= 12)
                {
                    climbersMonblan += peopleInGrup;
                }
                else if (peopleInGrup > 12 && peopleInGrup <= 25)
                {
                    climbersKilimanjaro += peopleInGrup;
                }
                else if (peopleInGrup > 25 && peopleInGrup <= 40)
                {
                    climbersK2 += peopleInGrup;
                }
                else
                {
                    climbersEverest += peopleInGrup;
                }
            }
            double percentMusala = climbersMusala * 100.0 / countOfClimbers;
            double percentMonblan = climbersMonblan * 100.0 / countOfClimbers;
            double percentKilimanjaro = climbersKilimanjaro * 100.0 / countOfClimbers;
            double percentK2 = climbersK2 * 100.0 / countOfClimbers;
            double percentEverest = climbersEverest * 100.0 / countOfClimbers;

            Console.WriteLine($"{percentMusala:F2}%");
            Console.WriteLine($"{percentMonblan:F2}%");
            Console.WriteLine($"{percentKilimanjaro:F2}%");
            Console.WriteLine($"{percentK2:F2}%");
            Console.WriteLine($"{percentEverest:F2}%");
        }
    }
}
