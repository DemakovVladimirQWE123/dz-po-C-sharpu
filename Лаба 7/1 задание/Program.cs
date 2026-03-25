namespace _1_задание
{
    internal class Program
    {
        static int[,] GenerateRandomArray(int rows, int cols, int a, int b)
        {
            Random rand = new Random();
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(a, b + 1);
                }
            }
            return array;
        }

        static void Main()
        {
            int[,] matrix = GenerateRandomArray(3, 4, 1, 10);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}