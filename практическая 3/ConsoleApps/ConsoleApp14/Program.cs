namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 14";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            bool evenLast = n % 2 == 0;
            Console.WriteLine($"а) заканчивается четной цифрой: {evenLast}");
            Console.WriteLine($"б) заканчивается нечетной цифрой: {!evenLast}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
