namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 24";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Масть m (1-4): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Достоинство k (6-14): ");
            int k = int.Parse(Console.ReadLine());

            string suit = m switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => "?"
            };

            string rank = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => "?"
            };

            string ending = suit switch
            {
                "пики" => "пик",
                "трефы" => "треф",
                "бубны" => "бубен",
                "червы" => "червей",
                _ => ""
            };

            Console.WriteLine($"{rank} {ending}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
