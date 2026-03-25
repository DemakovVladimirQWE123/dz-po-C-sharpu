namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 5";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(-100, 101);

            Console.WriteLine("Исходный массив: " + string.Join(" ", array));

            Console.WriteLine($"5.1 Сумма элементов с четными индексами: {SumEvenIndices(array)}");
            Console.WriteLine($"5.2 Минимальный положительный элемент: {MinPositive(array)}");
            Console.WriteLine($"5.3 Сумма максимального и минимального: {SumMinMax(array)}");
            Console.WriteLine($"5.4 Количество положительных: {CountPositive(array)}");

            Console.Write("Введите a и b для 5.5 (индексы): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"5.5 Сумма четных положительных с {a} по {b}: {SumEvenPositiveInRange(array, a, b)}");

            Console.WriteLine($"5.6 Среднее четных элементов: {AvgEven(array):F2}");
            Console.WriteLine($"5.7 Сумма четных положительных: {SumEvenPositive(array)}");
            Console.WriteLine($"5.8 Сумма неотрицательных на четных местах: {SumNonNegativeEvenPositions(array)}");

            Console.Write("Введите a и b для 5.9: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (maxVal, maxIdx) = MaxInRange(array, a, b);
            Console.WriteLine($"5.9 Максимум среди {a}–{b}: {maxVal}, индекс: {maxIdx}");

            var (minVal, minIdx) = MinEvenPositions(array);
            Console.WriteLine($"5.10 Минимум на четных позициях: {minVal}, индекс: {minIdx}");

            Console.Write("Введите a и b для 5.11: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (minVal2, minIdx2) = MinInRange(array, a, b);
            Console.WriteLine($"5.11 Минимум среди {a}–{b}: {minVal2}, индекс: {minIdx2}");

            Console.WriteLine($"5.12 Среднее элементов с нечетными индексами: {AvgOddIndices(array):F2}");
            Console.WriteLine($"5.13 Среднее элементов ≤ 50: {AvgNotExceeding50(array):F2}");

            SplitByParity(array, out int[] evenIndices, out int[] oddIndices);
            Console.WriteLine($"5.14 Четные индексы: {string.Join(" ", evenIndices)}");
            Console.WriteLine($"     Нечетные индексы: {string.Join(" ", oddIndices)}");

            SplitSpecial(array, out int[] evenElemOddIdx, out int[] oddElemEvenIdx);
            Console.WriteLine($"5.15 Четные элементы с нечетными индексами: {string.Join(" ", evenElemOddIdx)}");
            Console.WriteLine($"     Нечетные элементы с четными индексами: {string.Join(" ", oddElemEvenIdx)}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
        static int SumEvenIndices(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2) sum += arr[i];
            return sum;
        }

        static int MinPositive(int[] arr)
        {
            int min = int.MaxValue;
            foreach (int x in arr) if (x > 0 && x < min) min = x;
            return min == int.MaxValue ? 0 : min;
        }

        static int SumMinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (int x in arr) { if (x < min) min = x; if (x > max) max = x; }
            return min + max;
        }

        static int CountPositive(int[] arr)
        {
            int count = 0;
            foreach (int x in arr) if (x > 0) count++;
            return count;
        }

        static int SumEvenPositiveInRange(int[] arr, int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
                if (i >= 0 && i < arr.Length && arr[i] > 0 && arr[i] % 2 == 0)
                    sum += arr[i];
            return sum;
        }

        static double AvgEven(int[] arr)
        {
            int sum = 0, cnt = 0;
            foreach (int x in arr) if (x % 2 == 0) { sum += x; cnt++; }
            return cnt == 0 ? 0 : (double)sum / cnt;
        }

        static int SumEvenPositive(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) if (x > 0 && x % 2 == 0) sum += x;
            return sum;
        }

        static int SumNonNegativeEvenPositions(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2) if (arr[i] >= 0) sum += arr[i];
            return sum;
        }

        static (int value, int index) MaxInRange(int[] arr, int a, int b)
        {
            int max = int.MinValue, idx = -1;
            for (int i = a; i <= b; i++)
                if (i >= 0 && i < arr.Length && arr[i] > max) { max = arr[i]; idx = i; }
            return (max, idx);
        }

        static (int value, int index) MinEvenPositions(int[] arr)
        {
            int min = int.MaxValue, idx = -1;
            for (int i = 0; i < arr.Length; i += 2)
                if (arr[i] < min) { min = arr[i]; idx = i; }
            return (min, idx);
        }

        static (int value, int index) MinInRange(int[] arr, int a, int b)
        {
            int min = int.MaxValue, idx = -1;
            for (int i = a; i <= b; i++)
                if (i >= 0 && i < arr.Length && arr[i] < min) { min = arr[i]; idx = i; }
            return (min, idx);
        }

        static double AvgOddIndices(int[] arr)
        {
            int sum = 0, cnt = 0;
            for (int i = 1; i < arr.Length; i += 2) { sum += arr[i]; cnt++; }
            return cnt == 0 ? 0 : (double)sum / cnt;
        }

        static double AvgNotExceeding50(int[] arr)
        {
            int sum = 0, cnt = 0;
            foreach (int x in arr) if (x <= 50) { sum += x; cnt++; }
            return cnt == 0 ? 0 : (double)sum / cnt;
        }

        static void SplitByParity(int[] arr, out int[] evenIndices, out int[] oddIndices)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i < arr.Length; i++)
                if (i % 2 == 0) even.Add(arr[i]);
                else odd.Add(arr[i]);
            evenIndices = even.ToArray();
            oddIndices = odd.ToArray();
        }

        static void SplitSpecial(int[] arr, out int[] evenElemOddIdx, out int[] oddElemEvenIdx)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1 && arr[i] % 2 == 0) list1.Add(arr[i]);
                else if (i % 2 == 0 && arr[i] % 2 != 0) list2.Add(arr[i]);
            }
            evenElemOddIdx = list1.ToArray();
            oddElemEvenIdx = list2.ToArray();
        }
    }
}
