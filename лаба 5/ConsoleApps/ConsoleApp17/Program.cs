namespace ConsoleApp17
{
    using System;

    class Task17
    {
        // Пробег в N-й день
        static double DistanceOnDay(int day)
        {
            double distance = 10.0;
            for (int i = 2; i <= day; i++)
                distance *= 1.1;
            return distance;
        }

        // Суммарный путь за N дней
        static double TotalDistance(int days)
        {
            double total = 0.0;
            double current = 10.0;
            for (int i = 1; i <= days; i++)
            {
                total += current;
                current *= 1.1;
            }
            return total;
        }

        static void Main()
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Пробег в {n}-й день: {DistanceOnDay(n):F2} км");
            Console.WriteLine($"Суммарный путь за {n} дней: {TotalDistance(n):F2} км");
        }
    }
}
