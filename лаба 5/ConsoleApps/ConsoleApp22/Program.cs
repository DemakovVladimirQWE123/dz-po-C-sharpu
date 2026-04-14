namespace ConsoleApp22
{
    using System;

    class Task22
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static void Main()
        {
            Console.Write("x1 = "); double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = "); double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = "); double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = "); double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние = {Distance(x1, y1, x2, y2):F4}");
        }
    }
}
