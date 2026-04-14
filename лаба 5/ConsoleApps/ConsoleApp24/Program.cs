namespace ConsoleApp24
{
    using System;

    class Task24
    {
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static int Min(int a, int b, int c, int d)
        {
            int min = Min(a, b, c);
            if (d < min) min = d;
            return min;
        }

        static int Min(int a, int b, int c, int d, int e)
        {
            int min = Min(a, b, c, d);
            if (e < min) min = e;
            return min;
        }

        static void Main()
        {
            Console.WriteLine("Минимум из 4 чисел (1, 5, 3, 2): " + Min(1, 5, 3, 2));
            Console.WriteLine("Минимум из 5 чисел (7, 2, 9, 4, 1): " + Min(7, 2, 9, 4, 1));
        }
    }
}
