namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 19";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Стол a x b (a > b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("Кость c x d x e (c > d > e): ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int maxCount = 0;
            if (a >= c && b >= d) maxCount = (a / c) * (b / d);
            if (a >= d && b >= c) maxCount = Math.Max(maxCount, (a / d) * (b / c));
            Console.WriteLine($"Максимальное количество костей: {maxCount}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
