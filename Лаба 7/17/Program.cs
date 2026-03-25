namespace _17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(-1, 2);
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int swapRow = n - 1;
            bool lastRowAllZero = true;
            for (int j = 0; j < m; j++)
                if (a[n - 1, j] != 0) { lastRowAllZero = false; break; }
            if (lastRowAllZero && n > 1) swapRow = n - 2;
            if (swapRow >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            int temp = a[i, j];
                            a[i, j] = a[swapRow, j];
                            a[swapRow, j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("\nМатрица после:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
