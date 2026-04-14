namespace _3._7
{
    using System;

    namespace Task3_7
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Введите оценку {i}: ");
                    int grade = int.Parse(Console.ReadLine());
                    sum += grade;
                }
                double average = sum / 10.0;
                Console.WriteLine($"Средняя оценка: {average}");
            }
        }
    }
}
