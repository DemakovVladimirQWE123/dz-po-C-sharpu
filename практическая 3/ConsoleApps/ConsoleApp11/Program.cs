namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 11";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            double d = double.Parse(Console.ReadLine());

            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            Console.WriteLine($"Наибольшее: {max}");

            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            Console.WriteLine($"Наименьшее: {min}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
