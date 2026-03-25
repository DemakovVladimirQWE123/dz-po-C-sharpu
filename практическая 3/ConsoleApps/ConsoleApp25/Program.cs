namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 25";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("k (1-365): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("d (1-7, где 1=понедельник): ");
            int d = int.Parse(Console.ReadLine());

            int dayOfWeek = (k + d - 2) % 7 + 1;
            string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            Console.WriteLine($"День недели: {days[dayOfWeek - 1]}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
