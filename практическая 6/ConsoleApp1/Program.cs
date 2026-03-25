namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 1";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите M: ");
            int M = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = M;
            Console.WriteLine("Массив: " + string.Join(" ", arr));
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
