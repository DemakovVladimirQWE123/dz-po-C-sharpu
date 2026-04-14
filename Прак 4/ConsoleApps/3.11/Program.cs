namespace _3._11
{
    using System;

    namespace Task3_11
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double area = 100;          // начальная площадь, га
                double yieldPerHa = 20;      // начальная урожайность, ц/га
                double totalHarvest = 0;     // суммарный урожай за первые 6 лет

                for (int year = 1; year <= 8; year++)
                {
                    double harvest = area * yieldPerHa;

                    if (year <= 6)
                        totalHarvest += harvest;

                    if (year >= 2 && year <= 8)
                        Console.WriteLine($"а) Урожайность за {year}-й год: {harvest} центнеров");

                    if (year >= 4 && year <= 7)
                        Console.WriteLine($"б) Площадь участка в {year}-й год: {area:F2} га");

                    // изменения для следующего года
                    area *= 1.05;        // +5%
                    yieldPerHa *= 1.02;  // +2%
                }

                Console.WriteLine($"в) Урожай за первые 6 лет: {totalHarvest:F2} центнеров");
            }
        }
    }
}
