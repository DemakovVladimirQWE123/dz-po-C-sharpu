namespace _3._2
{
    using System;

    namespace Task3_2
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите число для вывода: ");
                int numToPrint = int.Parse(Console.ReadLine());
                Console.Write("Введите количество раз: ");
                int times = int.Parse(Console.ReadLine());
                for (int i = 0; i < times; i++)
                {
                    Console.Write(numToPrint + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
