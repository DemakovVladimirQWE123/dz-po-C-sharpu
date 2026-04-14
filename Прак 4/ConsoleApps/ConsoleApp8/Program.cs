namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int input;
            do
            {
                Console.Write("Введите число (0 для выхода): ");
                input = int.Parse(Console.ReadLine());
                if (input != 0)
                {
                    sum += input;
                    count++;
                }
            } while (input != 0);
            double average = count > 0 ? (double)sum / count : 0;
            Console.WriteLine($"Сумма: {sum}, Среднее арифметическое: {average}");
        }
    }
}
