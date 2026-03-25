namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 13";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Скорость в км/ч: ");
            double kmh = double.Parse(Console.ReadLine());
            Console.Write("Скорость в м/с: ");
            double ms = double.Parse(Console.ReadLine());

            double kmhMs = kmh * 1000 / 3600;
            if (kmhMs > ms)
                Console.WriteLine("Скорость в км/ч больше");
            else
                Console.WriteLine("Скорость в м/с больше");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
