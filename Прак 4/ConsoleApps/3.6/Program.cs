namespace _3._6
{
    using System;

    namespace Task3_6
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= 11; i += 2)
                {
                    double term = 1;
                    for (int j = 1; j <= i; j++)
                        term *= x;
                    sum += term / i;
                }
                Console.WriteLine($"Сумма = {sum}");
            }
        }
    }
}
