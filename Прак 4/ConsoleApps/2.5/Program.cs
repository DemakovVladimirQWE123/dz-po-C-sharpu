namespace _2._5
{
    using System;

    namespace Task2_5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите число M: ");
                int M = int.Parse(Console.ReadLine());
                int fib1 = 0;
                int fib2 = 1;
                Console.Write("Последовательность Фибоначчи: ");
                if (M >= 0) Console.Write(fib1 + " ");
                if (M >= 1)
                {
                    Console.Write(fib2 + " ");
                    int fibNext;
                    do
                    {
                        fibNext = fib1 + fib2;
                        if (fibNext <= M)
                            Console.Write(fibNext + " ");
                        fib1 = fib2;
                        fib2 = fibNext;
                    } while (fibNext <= M);
                }
                Console.WriteLine();
            }
        }
    }
}
