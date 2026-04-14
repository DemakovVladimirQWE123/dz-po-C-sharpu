namespace _3._10
{
    using System;

    namespace Task3_10
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double run = 10;        // пробег в первый день
                double totalRun = 0;    // суммарный путь за первые 7 дней

                for (int day = 1; day <= 10; day++)
                {
                    Console.WriteLine($"День {day}: {run:F2} км");
                    if (day <= 7)
                        totalRun += run;
                    run += run * 0.1;   // увеличение на 10%
                }

                Console.WriteLine($"Суммарный путь за первые 7 дней: {totalRun:F2} км");
            }
        }
    }
}
