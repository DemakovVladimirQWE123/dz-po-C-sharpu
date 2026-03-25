namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 4";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"а) x < 2 и y < 3 = {x < 2 && y < 3}");
            Console.WriteLine($"б) неверно, что x < 2 = {!(x < 2)}");
            Console.WriteLine($"в) x < 1 или y < 2 = {x < 1 || y < 2}");
            Console.WriteLine($"г) неверно, что (x < 0 и x < 5) = {!(x < 0 && x < 5)}");
            Console.WriteLine($"д) x < 0 и y > 5 = {x < 0 && y > 5}");
            Console.WriteLine($"е) 10 < x < 20 = {x > 10 && x < 20}");
            Console.WriteLine($"ж) x > 3 или x < 1 = {x > 3 || x < 1}");
            Console.WriteLine($"з) 0 < y < 4 и x < 5 = {y > 0 && y < 4 && x < 5}");
            Console.WriteLine($"и) x > 3 и x < 10 = {x > 3 && x < 10}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
