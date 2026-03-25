namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 22";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Стол a x b (a > b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("Прямоугольник c x d (c > d): ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int longSide = (a / c) * (b / d);
            int shortSide = (a / d) * (b / c);
            Console.WriteLine($"Вдоль длинной: {longSide}");
            Console.WriteLine($"Вдоль короткой: {shortSide}");

            if (longSide > shortSide)
                Console.WriteLine("Лучше вдоль длинной");
            else if (shortSide > longSide)
                Console.WriteLine("Лучше вдоль короткой");
            else
                Console.WriteLine("Одинаково");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
