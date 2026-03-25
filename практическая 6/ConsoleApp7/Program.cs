namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 7";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            if (n >= 1) fib[0] = 0;
            if (n >= 2) fib[1] = 1;
            for (int i = 2; i < n; i++)
                fib[i] = fib[i - 1] + fib[i - 2];
            Console.WriteLine("Числа Фибоначчи: " + string.Join(" ", fib));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
