namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 18";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine($"Год {year} високосный: {isLeap}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
