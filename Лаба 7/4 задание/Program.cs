namespace _4_задание
{
    internal class Program
    {
        static void Main()
        {
            int rows = 6;
            int cols = 11;
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 5);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                int max = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                sum += max;
            }
            Console.WriteLine("\nСумма максимальных элементов в каждом столбце: " + sum);
        }
    }
}
