namespace _3._14
{
    using System;

    namespace Task3_14
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите n (1 < n <= 10): ");
                int n = int.Parse(Console.ReadLine());
                long factSum = 0;
                long fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                    factSum += fact;
                }
                Console.WriteLine($"Сумма факториалов от 1! до {n}! = {factSum}");
            }
        }
    }
}
