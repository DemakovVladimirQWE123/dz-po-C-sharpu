namespace ConsoleApp4
{
    using System;

    class Task4
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }

        static double SumReciprocalFactorials(int n)
        {
            double sum = 1.0; // 1 = 1/0! (0! = 1)
            for (int i = 1; i <= n; i++)
                sum += 1.0 / Factorial(i);
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма = {SumReciprocalFactorials(n)}");
        }
    }
}
