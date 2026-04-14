namespace ConsoleApp19
{
    using System;

    class Task19
    {
        // Урожайность в N-й год (ц/га)
        static double YieldInYear(int year)
        {
            double yield = 20.0;
            for (int i = 2; i <= year; i++)
                yield *= 1.02;
            return yield;
        }

        // Площадь в N-й год (га)
        static double AreaInYear(int year)
        {
            double area = 100.0;
            for (int i = 2; i <= year; i++)
                area *= 1.05;
            return area;
        }

        // Общий урожай за N лет (центнеров)
        static double TotalHarvest(int years)
        {
            double total = 0.0;
            double area = 100.0;
            double yield = 20.0;
            for (int i = 1; i <= years; i++)
            {
                total += area * yield;
                area *= 1.05;
                yield *= 1.02;
            }
            return total;
        }

        static void Main()
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Урожайность в {n}-й год: {YieldInYear(n):F2} ц/га");
            Console.WriteLine($"Площадь в {n}-й год: {AreaInYear(n):F2} га");
            Console.WriteLine($"Общий урожай за {n} лет: {TotalHarvest(n):F2} ц");
        }
    }
}
