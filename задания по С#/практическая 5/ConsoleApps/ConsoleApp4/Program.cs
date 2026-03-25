namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 5. Проект 4";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите число M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите длину ряда N: ");
            int n = int.Parse(Console.ReadLine());

            PrintRow(m, n);
            Console.WriteLine("Введите любую клавишу...");
            Console.ReadKey();
        }
        static void PrintRow(int m, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(m);
                if (i < n - 1)
                    Console.WriteLine(" ");
            }

        }

    }
    
}
