using System;

class Program
{
    static void Main()
    {
        Console.Title = "Практическая 5. Проект 5";
        Console.WindowWidth = 60;
        Console.WindowHeight = 13;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.ReadKey();
        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine());

        long result = Factorial(k);
        Console.WriteLine($"{k}! = {result}");
    }

    static long Factorial(int k)
    {
        if (k < 0)
            throw new ArgumentException("Факториаla nema");

        long result = 1;

        for (int i = 1; i <= k; i++)
        {
            result *= i;
        }

        return result;
    }
}