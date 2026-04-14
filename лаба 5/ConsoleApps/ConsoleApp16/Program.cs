namespace ConsoleApp16
{
    using System;

    class Task16
    {
        static int MonthsToTarget(double deposit, double percent, double target)
        {
            int months = 0;
            double current = deposit;
            while (current < target)
            {
                current += current * percent / 100.0;
                months++;
            }
            return months;
        }

        static void Main()
        {
            Console.Write("Начальный вклад: ");
            double deposit = double.Parse(Console.ReadLine());
            Console.Write("Ежемесячный процент: ");
            double percent = double.Parse(Console.ReadLine());
            Console.Write("Необходимая сумма: ");
            double target = double.Parse(Console.ReadLine());

            int months = MonthsToTarget(deposit, percent, target);
            Console.WriteLine($"Потребуется месяцев: {months}");
        }
    }
}
