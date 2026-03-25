namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 21";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите величину сдвига m: ");
            int m = int.Parse(Console.ReadLine());
            m = m % n; // на случай сдвига больше n

            // Циклический сдвиг влево на m
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = arr[(i + m) % n];

            Console.WriteLine("После сдвига: " + string.Join(" ", result));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
