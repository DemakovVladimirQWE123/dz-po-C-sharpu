namespace ConsoleApp23
{
    using System;

    class Task23
    {
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static void Main()
        {
            Console.Write("a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("b = "); int b = int.Parse(Console.ReadLine());
            Console.Write("c = "); int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Минимум = {Min(a, b, c)}");
        }
    }
}
