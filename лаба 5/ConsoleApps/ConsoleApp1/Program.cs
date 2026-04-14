namespace ConsoleApp1
{
    using System;

    class Task1
    {
        static void PrintSeries(int m, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(m + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            PrintSeries(m, n);
        }
    }
}
