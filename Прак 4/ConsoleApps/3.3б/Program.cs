namespace _3._3б
{
    using System;

    namespace Task3_3b
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите b (b > 10): ");
                int b = int.Parse(Console.ReadLine());
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
