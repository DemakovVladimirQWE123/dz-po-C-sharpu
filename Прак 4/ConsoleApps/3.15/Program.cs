namespace _3._15
{
    using System;

    namespace Task3_15
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите n (1 < n <= 10): ");
                int n = int.Parse(Console.ReadLine());
                double sum = 1.0;       // первое слагаемое 1
                long fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                    sum += 1.0 / fact;
                }
                Console.WriteLine($"Сумма 1 + 1/1! + ... + 1/{n}! = {sum}");
            }
        }
    }
}
