namespace _11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("ДА ЧЕМУ РАВНО N! ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("А M! ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(-2, 2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int maxSum = int.MinValue, maxRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += a[i, j];
                if (sum > maxSum) { maxSum = sum; maxRow = i; }
            }
            int[] row = new int[m];
            for (int j = 0; j < m; j++)
                row[j] = a[maxRow, j];
            Console.Write("\nСтрока с макс суммой (индекс {0}): ", maxRow + 1);
            for (int j = 0; j < m; j++)
                Console.Write(row[j] + " ");
            Console.WriteLine();
        }
    }
}
