namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 8";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"Больше: {a}, Меньше: {b}");
            else
                Console.WriteLine($"Больше: {b}, Меньше: {a}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
