namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 9";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            double max = a > b ? a : b;
            double min = a < b ? a : b;
            Console.WriteLine($"Максимальное: {max}, Минимальное: {min}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
