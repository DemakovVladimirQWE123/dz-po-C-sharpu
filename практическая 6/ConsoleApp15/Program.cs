namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 15";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину массива n (n > 4): ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 4) { Console.WriteLine("n должно быть больше 4"); return; }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] newArr = new int[n - 4];
            Array.Copy(arr, 0, newArr, 0, n - 4);
            Console.WriteLine("Новый массив (без последних 4 элементов): " + string.Join(" ", newArr));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
