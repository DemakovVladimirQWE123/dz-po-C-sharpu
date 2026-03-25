namespace _3_задание
{
    internal class Program
    {
        static void Main()
        {
            int rows = 15;
            int cols = 9;
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(0, 7);
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

            Console.WriteLine("\nМинимальные элементы в каждой строке:");
            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine("Строка " + (i + 1) + ": " + min);
            }
        }
    }
}
