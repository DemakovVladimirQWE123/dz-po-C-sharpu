namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 4";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int[] arr = new int[17];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-50, 101);

            int sum = 0;
            int count = 0;
            foreach (int x in arr)
                if (x > 0 && x % 2 != 0)
                {
                    sum += x;
                    count++;
                }
            double avg = count > 0 ? (double)sum / count : 0;
            Console.WriteLine("Массив: " + string.Join(" ", arr));
            Console.WriteLine($"Среднее значение нечётных положительных элементов: {avg}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
