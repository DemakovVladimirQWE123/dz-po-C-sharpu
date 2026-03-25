namespace _14
{
    internal class Program
    {
        static void Main()
        {
            int n = 5, m = 6;
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(-3, 4);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int minAbs = Math.Abs(a[0, 0]);
            int row = 1, col = 1;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (Math.Abs(a[i, j]) < minAbs)
                    {
                        minAbs = Math.Abs(a[i, j]);
                        row = i + 1;
                        col = j + 1;
                    }
            Console.WriteLine($"\nНаименьший по модулю: {minAbs} на ({row},{col})");
        }
    }
}
