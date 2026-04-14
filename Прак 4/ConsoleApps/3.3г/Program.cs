namespace _3._3г
{
    using System;

    namespace Task3_3g
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                int b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    for (int i = a; i >= b; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: b должно быть меньше a.");
                }
            }
        }
    }
}
