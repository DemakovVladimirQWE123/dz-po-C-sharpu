namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 16";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"а) {a} является делителем {b}: {b % a == 0}");
            Console.WriteLine($"б) {b} является делителем {a}: {a % b == 0}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
