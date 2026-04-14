namespace _3._5
{
    using System;

    namespace Task3_5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                        sum -= 1.0 / i;
                    else
                        sum += 1.0 / i;
                }
                Console.WriteLine($"Сумма = {sum}");
            }
        }
    }
}
