namespace _3._12
{
    using System;

    namespace Task3_12
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                int oddSum = 0;
                for (int i = 1; i <= n; i++)
                {
                    oddSum += 2 * i - 1;
                    Console.WriteLine($"{i}^2 = {oddSum}");
                }
            }
        }
    }
}
