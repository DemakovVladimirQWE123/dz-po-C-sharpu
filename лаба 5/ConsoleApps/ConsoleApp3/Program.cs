namespace ConsoleApp3
{
    using System;

    class Task3
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }

        static int SumFactorials(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += Factorial(i);
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма факториалов = {SumFactorials(n)}");
        }
    }
}
