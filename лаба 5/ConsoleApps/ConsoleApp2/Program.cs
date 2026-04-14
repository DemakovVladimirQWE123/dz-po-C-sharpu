namespace ConsoleApp2
{
    using System;

    class Task2
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }

        static void Main()
        {
            Console.Write("Введите k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"{k}! = {Factorial(k)}");
        }
    }
}
