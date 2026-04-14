namespace _3._4б
{
    using System;

    namespace Task3_4b
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                for (int i = 25; i <= 35; i++)
                {
                    Console.WriteLine($"{i} {i}.5 {i - 0.2:F1}");
                }
            }
        }
    }
}
