namespace _16
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
                    a[i, j] = r.Next(-50, 51);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            Console.Write("Величина: ");
            double val = double.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                    sum += a[i, j];
                double avg = sum / m;
                if (avg < val) count++;
            }
            Console.WriteLine($"Ответ!!! {val}: {count}");
        }
    }

}
