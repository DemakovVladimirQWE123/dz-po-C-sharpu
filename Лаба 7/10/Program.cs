namespace _10
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введи башмак чему равно N! ");
            int n = int.Parse(Console.ReadLine());
            int[,] m = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m[i, j] = r.Next(-2, 2);
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += m[i, j];
                if (sum > maxSum) { maxSum = sum; maxRow = i; }
            }
            int[] rowArray = new int[n];
            for (int j = 0; j < n; j++)
                rowArray[j] = m[maxRow, j];
            Console.Write("\nСтрока с макс суммой (индекс {0}): ", maxRow + 1);
            for (int j = 0; j < n; j++)
                Console.Write(rowArray[j] + " ");
            Console.WriteLine();
        }
    }
}
