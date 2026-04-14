namespace ConsoleApp25
{
    using System;

    class Task25
    {
        static int Add(int a, int b) => a + b;
        static int Add(int a, int b, int c) => a + b + c;
        static int Add(int a, int b, int c, int d) => a + b + c + d;

        static void Main()
        {
            Console.WriteLine("2 + 3 = " + Add(2, 3));
            Console.WriteLine("1 + 2 + 3 = " + Add(1, 2, 3));
            Console.WriteLine("5 + 6 + 7 + 8 = " + Add(5, 6, 7, 8));
        }
    }
}
