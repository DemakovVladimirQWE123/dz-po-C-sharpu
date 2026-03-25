namespace _7
{
    internal class Program
    {
        static void Main()
        {
            int[,] m = new int[7, 4];
            Random r = new Random();
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    m[i, j] = r.Next(-2, 2);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
            Console.Write("\nСтроки с нечётным отрицательным: ");
            bool found = false;
            for (int i = 0; i < 7; i++)
            {
                bool has = false;
                for (int j = 0; j < 4; j++)
                    if (m[i, j] < 0 && m[i, j] % 2 != 0) { has = true; break; }
                if (has) { Console.Write((i + 1) + " "); found = true; }
            }
            if (!found) Console.Write("нет");
            Console.WriteLine();
        }
    }
}
