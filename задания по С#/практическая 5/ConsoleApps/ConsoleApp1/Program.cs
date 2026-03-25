namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 5. Проект 1";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int a = 1;
            int b = 2;
            double Summa(double a, double b)
            {
                return a + b;
            }
            Console.WriteLine(Summa(a, b));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
