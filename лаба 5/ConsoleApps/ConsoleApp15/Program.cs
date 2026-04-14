namespace ConsoleApp15
{
    using System;

    class Task15
    {
        static double AverageMass(int count)
        {
            double sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Масса предмета {i}: ");
                sum += double.Parse(Console.ReadLine());
            }
            return sum / count;
        }

        static void Main()
        {
            Console.Write("Количество предметов: ");
            int n = int.Parse(Console.ReadLine());
            double avg = AverageMass(n);
            Console.WriteLine($"Средняя масса: {avg:F2}");
        }
    }
}
