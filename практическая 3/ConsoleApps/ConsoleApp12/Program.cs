namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 12";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Расстояние в километрах: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Расстояние в футах: ");
            double ft = double.Parse(Console.ReadLine());

            double kmM = km * 1000;
            double ftM = ft * 0.305;

            if (kmM < ftM)
                Console.WriteLine("Расстояние в километрах меньше");
            else
                Console.WriteLine("Расстояние в футах меньше");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
