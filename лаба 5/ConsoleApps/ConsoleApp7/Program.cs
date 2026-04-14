namespace ConsoleApp7
{
    using System;

    class Task7
    {
        static double AlternatingSum(int n)
        {
            double sum = 0.0;
            int sign = 1; // для первого члена (+)
            for (int i = 1; i <= n; i++)
            {
                sum += sign * 1.0 / i;
                sign = -sign; // меняем знак
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма = {AlternatingSum(n)}");
        }
    }
}
