namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 11";
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
            List<int> newArr = new List<int>();
            foreach (int x in arr)
                if (x % 2 == 0) newArr.Add(x);
            Console.WriteLine("Новый массив (без нечётных): " + string.Join(" ", newArr));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
