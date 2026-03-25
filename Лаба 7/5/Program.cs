namespace _5
{
    internal class Program
    {
        static void Main()
        {
            int[,] m = new int[5, 8];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    m[i, j] = r.Next(-1, 1);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            Console.Write("\nСтолбцы с отрицательными: ");
            for (int j = 0; j < 8; j++)
            {
                bool hasNeg = false;
                for (int i = 0; i < 5; i++)
                    if (m[i, j] < 0) { hasNeg = true; break; }
                if (hasNeg) Console.Write((j + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
