namespace ConsoleApp14
{
    using System;

    class Task14
    {
        static double AverageGrade()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Оценка {i}: ");
                sum += int.Parse(Console.ReadLine());
            }
            return sum / 10.0;
        }

        static void Main()
        {
            double avg = AverageGrade();
            Console.WriteLine($"Средняя оценка: {avg:F2}");
        }
    }
}
