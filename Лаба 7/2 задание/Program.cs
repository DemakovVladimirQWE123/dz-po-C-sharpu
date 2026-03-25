namespace _2_задание
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int[] oneDim = { 1, 2, 3, 4, 5 };
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            PrintArray(oneDim);
            PrintArray(twoDim);
        }
    }
}