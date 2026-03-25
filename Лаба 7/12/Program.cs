namespace _12
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
                    a[i, j] = r.Next(-2, 2);
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int minIdx = 0;
                for (int j = 1; j < m; j++)
                    if (a[i, j] < a[i, minIdx]) minIdx = j;
                if (minIdx != 0)
                {
                    int temp = a[i, 0];
                    a[i, 0] = a[i, minIdx];
                    a[i, minIdx] = temp;
                }
            }
            Console.WriteLine("\nМатрица после замены:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
