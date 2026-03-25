namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 26";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Количество месяцев n: ");
            int n = int.Parse(Console.ReadLine());
            int month = (1 + n) % 12;
            if (month == 0) month = 12;
            string[] months = { "январь", "февраль", "март", "апрель", "май", "июнь",
                    "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            Console.WriteLine($"Месяц: {months[month - 1]}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
