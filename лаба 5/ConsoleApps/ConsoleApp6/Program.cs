namespace ConsoleApp6
{
    using System;

    class Task6
    {
        static int SquareByOddSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 2 * i - 1;
            return sum;
        }

        static int SumOfSquares(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
                total += SquareByOddSum(i);
            return total;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма квадратов = {SumOfSquares(n)}");
        }
    }
}
