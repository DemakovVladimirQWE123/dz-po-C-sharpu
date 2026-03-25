namespace _15
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mat[i, j] = r.Next(-50, 51);
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            List<int> kept = new List<int>();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (mat[i, j] < a || mat[i, j] > b)
                        kept.Add(mat[i, j]);
            int total = n * m;
            int[] flat = new int[total];
            for (int i = 0; i < kept.Count; i++)
                flat[i] = kept[i];
            for (int i = kept.Count; i < total; i++)
                flat[i] = 0;
            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    result[i, j] = flat[i * m + j];
            Console.WriteLine("Сжатая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(result[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
