namespace _13
{
    internal class Program
    {
        static void Main()
        {
            int[,] m = new int[8, 5];
            Random r = new Random();
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 5; j++)
                    m[i, j] = r.Next(228, 1488);
            Console.WriteLine("Матрица:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            int rowNum = -1;
            for (int i = 0; i < 8; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < 5; j++)
                    if (m[i, j] % 2 == 0) evenCount++;
                if (evenCount <= 3) { rowNum = i + 1; break; }
            }
            if (rowNum != -1)
                Console.WriteLine("\nНомер строки с не более 3 чётных: " + rowNum);
        }
    }
}
