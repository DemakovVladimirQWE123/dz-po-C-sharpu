namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 23";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, 1000);
            Console.WriteLine("Исходный массив: " + string.Join(" ", arr));

            Console.WriteLine("\nВыберите критерий сортировки:");
            Console.WriteLine("1 - По сумме цифр");
            Console.WriteLine("2 - По последней цифре");
            Console.WriteLine("3 - По первой цифре");
            int crit = int.Parse(Console.ReadLine());

            int[] copy = (int[])arr.Clone();

            if (crit == 1)
                Array.Sort(copy, (a, b) => SumDigits(a).CompareTo(SumDigits(b)));
            else if (crit == 2)
                Array.Sort(copy, (a, b) => (a % 10).CompareTo(b % 10));
            else if (crit == 3)
                Array.Sort(copy, (a, b) => FirstDigit(a).CompareTo(FirstDigit(b)));
            else Console.WriteLine("Неверный выбор.");

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", copy));

            static int SumDigits(int x)
            {
                int sum = 0;
                x = Math.Abs(x);
                while (x > 0)
                {
                    sum += x % 10;
                    x /= 10;
                }
                return sum;
            }

            static int FirstDigit(int x)
            {
                x = Math.Abs(x);
                while (x >= 10) x /= 10;
                return x;
            }
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
