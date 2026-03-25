namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 19";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите размер первого массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arrN[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите размер второго массива m: ");
            int m = int.Parse(Console.ReadLine());
            int[] arrM = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arrM[i] = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("\nВыберите подзадачу (1-3) или 0 для выхода:");
                int sub = int.Parse(Console.ReadLine());
                if (sub == 0) break;

                if (sub == 1)
                {
                    List<int> result = new List<int>();
                    foreach (int x in arrN)
                        if (!Array.Exists(arrM, y => y == x))
                            result.Add(x);
                    Console.WriteLine("Элементы из n, отсутствующие в m: " + string.Join(" ", result));
                }
                else if (sub == 2)
                {
                    List<int> result = new List<int>();
                    foreach (int x in arrN)
                        if (Array.Exists(arrM, y => y == x) && !result.Contains(x))
                            result.Add(x);
                    Console.WriteLine("Общие элементы: " + string.Join(" ", result));
                }
                else if (sub == 3)
                {
                    List<int> result = new List<int>();
                    foreach (int x in arrN)
                        if (!Array.Exists(arrM, y => y == x))
                            result.Add(x);
                    foreach (int x in arrM)
                        if (!Array.Exists(arrN, y => y == x))
                            result.Add(x);
                    Console.WriteLine("Симметрическая разность: " + string.Join(" ", result));
                }
                else Console.WriteLine("Неверный выбор.");
            }
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
