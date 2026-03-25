namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 20";
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
            Array.Reverse(arr);
            Console.WriteLine("Массив в обратном порядке: " + string.Join(" ", arr));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
