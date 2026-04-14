namespace ConsoleApp18
{
    using System;

    class Task18
    {
        // Расстояние от дома (по модулю)
        static double DistanceFromHome(int n)
        {
            double position = 0.0;
            int direction = 1; // 1 – от дома, -1 – к дому
            for (int i = 1; i <= n; i++)
            {
                position += direction * (1.0 / i);
                direction *= -1;
            }
            return Math.Abs(position);
        }

        // Общий пройденный путь
        static double TotalPath(int n)
        {
            double path = 0.0;
            for (int i = 1; i <= n; i++)
                path += 1.0 / i;
            return path;
        }

        static void Main()
        {
            Console.Write("Введите количество этапов N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Расстояние от дома после {n} этапов: {DistanceFromHome(n):F4} км");
            Console.WriteLine($"Общий пройденный путь: {TotalPath(n):F4} км");
        }
    }
}
