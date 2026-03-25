namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 7";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y = x > 0 ? Math.Sin(x) : Math.Cos(x);
            Console.WriteLine($"y = {y}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
