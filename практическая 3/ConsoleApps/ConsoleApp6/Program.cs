namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 6";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите целое число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine($"а) целое А кратно двум или трем: {A % 2 == 0 || A % 3 == 0}");
            Console.WriteLine($"б) целое А не кратно трем и оканчивается нулем: {A % 3 != 0 && A % 10 == 0}");

            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"в) целое N кратно пяти или семи: {N % 5 == 0 || N % 7 == 0}");
            Console.WriteLine($"г) целое N кратно четырем и не оканчивается нулем: {N % 4 == 0 && N % 10 != 0}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
