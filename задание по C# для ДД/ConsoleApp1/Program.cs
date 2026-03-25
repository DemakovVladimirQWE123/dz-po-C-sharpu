namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Задание УАН";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Введите х (от -5 до 5):");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = x - 10;
            double y;
            if (x < 0)
            {
                y = 120 / (-x);
            }
            else
            {
                y = x / 35 - a;
            }
            Console.WriteLine("у = " + y);
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
