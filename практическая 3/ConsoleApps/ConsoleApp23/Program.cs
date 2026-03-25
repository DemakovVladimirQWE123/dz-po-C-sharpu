namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 23";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Номер карты k (6-14): ");
            int k = int.Parse(Console.ReadLine());
            string name = k switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => "неизвестная"
            };
            Console.WriteLine($"Карта: {name}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
