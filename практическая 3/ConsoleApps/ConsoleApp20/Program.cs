namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 20";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите k (1-365): ");
            int k = int.Parse(Console.ReadLine());
            int dow = k % 7;
            bool weekend = dow == 6 || dow == 0;
            Console.WriteLine($"k-й день года: {(weekend ? "выходной" : "рабочий")}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
