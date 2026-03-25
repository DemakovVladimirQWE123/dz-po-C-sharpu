namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 21";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите время t (мин от начала часа): ");
            double t = double.Parse(Console.ReadLine());
            int cycle = (int)t % 5;
            string color = cycle < 3 ? "зеленый" : "красный";
            Console.WriteLine($"Сигнал: {color}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
