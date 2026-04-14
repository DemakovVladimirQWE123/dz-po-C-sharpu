namespace _3._8
{
    using System;

    namespace Task3_8
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Введите количество предметов: ");
                int count = int.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= count; i++)
                {
                    Console.Write($"Введите массу предмета {i}: ");
                    sum += double.Parse(Console.ReadLine());
                }
                double average = sum / count;
                Console.WriteLine($"Средняя масса: {average}");
            }
        }
    }
}
