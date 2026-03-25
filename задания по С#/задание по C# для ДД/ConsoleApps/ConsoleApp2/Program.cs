namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Задание ТУ";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int x = -5;  x <= 5; x++)
            {
                double y;
                if (x < 0)
                {
                    y = 120.0 / (-x);
                }
                else
                {
                    double a = x - 10;
                    y = x / 35.0 - a;
                }
                Console.WriteLine(x + "\t" + y);
            }
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
