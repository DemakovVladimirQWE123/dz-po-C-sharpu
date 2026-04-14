namespace ConsoleApp8
{
    using System;

    class Task8
    {
        static double SumSeries(double x)
        {
            double sum = 0.0;
            double term = x; // x^1
            for (int i = 1; i <= 11; i += 2)
            {
                sum += term / i;
                term *= x * x; // для следующей нечётной степени
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма ряда = {SumSeries(x)}");
        }
    }
}
