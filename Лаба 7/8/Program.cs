namespace _8
{
    internal class Program
    {
        static void Main()
        {
            int[,] m = new int[4, 6];
            Random r = new Random();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    m[i, j] = r.Next(-2, 2);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            int[] sums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 6; j++)
                    sum += m[i, j];
                sums[i] = sum;
            }
            Console.Write("\nСуммы строк: ");
            for (int i = 0; i < 4; i++)
                Console.Write(sums[i] + " ");
            int maxSum = sums[0];
            for (int i = 1; i < 4; i++)
                if (sums[i] > maxSum) maxSum = sums[i];
            Console.WriteLine("\nМаксимальная сумма: " + maxSum);
        }
    }
}
