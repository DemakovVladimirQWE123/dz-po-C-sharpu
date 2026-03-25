namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 2";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            double[] arr = new double[8];
            double sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            double avg = count > 0 ? sum / count : 0;
            Console.WriteLine($"Среднее арифметическое положительных элементов: {avg}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
