namespace _3._3в
{
    using System;

    namespace Task3_3v
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите a (a < 50): ");
                int a = int.Parse(Console.ReadLine());
                for (int i = a; i <= 50; i++)
                {
                    Console.WriteLine(i * i * i);
                }
            }
        }
    }
}
