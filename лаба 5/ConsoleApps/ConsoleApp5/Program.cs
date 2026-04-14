namespace ConsoleApp5
{
    using System;

    class Task5
    {
        static int SquareByOddSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 2 * i - 1;
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}^2 = {SquareByOddSum(n)}");
        }
    }
}
