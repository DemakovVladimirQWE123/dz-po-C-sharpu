namespace ConsoleApp13
{
    using System;

    class Task13
    {
        static void PrintFibonacciUpTo(int m)
        {
            int a = 0, b = 1;
            Console.Write("Ряд Фибоначчи: ");
            if (m >= 0) Console.Write(a + " ");
            if (m >= 1) Console.Write(b + " ");

            while (true)
            {
                int next = a + b;
                if (next > m) break;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите M: ");
            int m = int.Parse(Console.ReadLine());
            PrintFibonacciUpTo(m);
        }
    }
}
