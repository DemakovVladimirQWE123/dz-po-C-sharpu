namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 16";
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
            bool skip = true;
            foreach (int x in arr)
            {
                if (skip && x < 20) continue;
                skip = false;
                newArr.Add(x);
            }
            Console.WriteLine("Новый массив: " + string.Join(" ", newArr));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
