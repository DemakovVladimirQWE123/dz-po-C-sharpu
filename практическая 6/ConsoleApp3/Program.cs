namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 3";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-100, 101);

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (i % 2 == 1 && arr[i] < 0)
                    sum += arr[i];

            Console.WriteLine("Массив: " + string.Join(" ", arr));
            Console.WriteLine($"Сумма отрицательных элементов на нечётных местах: {sum}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
