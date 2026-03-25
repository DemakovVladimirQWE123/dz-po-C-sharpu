namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 17";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Первый прямоугольник:");
            Console.Write("x1: "); int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: "); int y1 = int.Parse(Console.ReadLine());
            Console.Write("ширина: "); int w1 = int.Parse(Console.ReadLine());
            Console.Write("высота: "); int h1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Второй прямоугольник:");
            Console.Write("x2: "); int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: "); int y2 = int.Parse(Console.ReadLine());
            Console.Write("ширина: "); int w2 = int.Parse(Console.ReadLine());
            Console.Write("высота: "); int h2 = int.Parse(Console.ReadLine());

            int x1r = x1 + w1, y1t = y1 + h1;
            int x2r = x2 + w2, y2t = y2 + h2;

            bool firstInSecond = x1 >= x2 && y1 >= y2 && x1r <= x2r && y1t <= y2t;
            Console.WriteLine($"а) первый во втором: {firstInSecond}");

            bool secondInFirst = x2 >= x1 && y2 >= y1 && x2r <= x1r && y2t <= y1t;
            Console.WriteLine($"б) один в другом: {firstInSecond || secondInFirst}");

            bool intersect = !(x1r < x2 || x2r < x1 || y1t < y2 || y2t < y1);
            Console.WriteLine($"в) пересекаются: {intersect}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
