namespace _9
{
    internal class Program
    {
        static void Main()
        {
            int n = 5;
            int[,] m = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m[i, j] = r.Next(-2, 2);
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            int minVal = m[0, 0], maxVal = m[0, 0];
            int minIdx = 0, maxIdx = 0;
            for (int i = 1; i < n; i++)
            {
                if (m[i, i] < minVal) { minVal = m[i, i]; minIdx = i; }
                if (m[i, i] > maxVal) { maxVal = m[i, i]; maxIdx = i; }
            }
            int temp = m[minIdx, minIdx];
            m[minIdx, minIdx] = m[maxIdx, maxIdx];
            m[maxIdx, maxIdx] = temp;
            Console.WriteLine("\nМатрица после обмена:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
