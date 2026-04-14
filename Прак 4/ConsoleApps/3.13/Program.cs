namespace _3._13
{
    using System;

    namespace Task3_13
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int sumSquares = 0;
                int oddSum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    oddSum += 2 * i - 1;   // i-й квадрат
                    sumSquares += oddSum;
                }
                Console.WriteLine($"Сумма квадратов от 1 до 10: {sumSquares}");
            }
        }
    }
}
