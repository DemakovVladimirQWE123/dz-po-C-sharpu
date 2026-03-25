namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 2. Проект 1";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next(5));
            Console.WriteLine(rnd.Next(-5,5));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
