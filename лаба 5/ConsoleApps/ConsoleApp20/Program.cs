namespace ConsoleApp20
{
    using System;

    class Task20
    {
        static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main()
        {
            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Периметр = {Perimeter(a, b, c)}");
        }
    }
}
