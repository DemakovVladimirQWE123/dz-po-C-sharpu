namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 8";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1 - 1, -1/2, 1/3, -1/4, ...");
            Console.WriteLine("2 - x, x^3/3, ..., x^n/n");
            Console.WriteLine("3 - 1, 1/2!, 1/3!, ...");
            int var = int.Parse(Console.ReadLine());

            if (var == 1)
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= n; i++)
                    sum += (i % 2 == 1 ? 1.0 : -1.0) / i;
                Console.WriteLine($"Сумма = {sum}");
            }
            else if (var == 2)
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                double sum = 0;
                for (int k = 1; k <= n; k++)
                    sum += Math.Pow(x, k) / k;
                Console.WriteLine($"Сумма = {sum}");
            }
            else if (var == 3)
            {
                Console.Write("Введите n: ");
                int n = int.Parse(Console.ReadLine());
                double sum = 0;
                long fact = 1;
                for (int k = 1; k <= n; k++)
                {
                    fact *= k;
                    sum += 1.0 / fact;
                }
                Console.WriteLine($"Сумма = {sum}");
            }
            else Console.WriteLine("Неверный выбор.");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
