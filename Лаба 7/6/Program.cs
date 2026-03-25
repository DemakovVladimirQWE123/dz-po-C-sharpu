namespace _6
{
    internal class Program
    {
        static void Main()
        {
            int[,] m = new int[5, 10];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                    m[i, j] = r.Next(-1, 1);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            Console.Write("\nСтроки только с положительными: ");
            for (int i = 0; i < 5; i++)
            {
                bool allPos = true;
                for (int j = 0; j < 10; j++)
                    if (m[i, j] <= 0) { allPos = false; break; }
                if (allPos) Console.Write((i + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
