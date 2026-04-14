namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            Console.Write("Цифры числа: ");
            while (temp > 0)
            {
                int digit = temp % 10;
                Console.Write(digit + " ");
                temp /= 10;
            }
            Console.WriteLine();
        }
    }
}
