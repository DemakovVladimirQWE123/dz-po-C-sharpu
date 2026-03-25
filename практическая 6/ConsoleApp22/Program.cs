namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 22";
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
                arr[i] = rnd.Next(-100, 101);
            Console.WriteLine("Исходный массив: " + string.Join(" ", arr));

            Console.WriteLine("\nВыберите метод сортировки:");
            Console.WriteLine("1 - Пузырьком");
            Console.WriteLine("2 - Выбором");
            Console.WriteLine("3 - Быстрая сортировка");
            int method = int.Parse(Console.ReadLine());

            int[] copy = (int[])arr.Clone(); // чтобы не испортить исходный

            if (method == 1) // Пузырьком
            {
                for (int i = 0; i < copy.Length - 1; i++)
                    for (int j = 0; j < copy.Length - i - 1; j++)
                        if (copy[j] > copy[j + 1])
                        {
                            int temp = copy[j];
                            copy[j] = copy[j + 1];
                            copy[j + 1] = temp;
                        }
            }
            else if (method == 2) // Выбором
            {
                for (int i = 0; i < copy.Length - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < copy.Length; j++)
                        if (copy[j] < copy[minIndex])
                            minIndex = j;
                    if (minIndex != i)
                    {
                        int temp = copy[i];
                        copy[i] = copy[minIndex];
                        copy[minIndex] = temp;
                    }
                }
            }
            else if (method == 3) // Быстрая сортировка
            {
                QuickSort(copy, 0, copy.Length - 1);
            }
            else Console.WriteLine("Неверный выбор.");

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", copy));

            static void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);
                    QuickSort(arr, left, pivot - 1);
                    QuickSort(arr, pivot + 1, right);
                }
            }

            static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[right];
                int i = left - 1;
                for (int j = left; j < right; j++)
                    if (arr[j] <= pivot)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                int temp2 = arr[i + 1];
                arr[i + 1] = arr[right];
                arr[right] = temp2;
                return i + 1;
            }
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
