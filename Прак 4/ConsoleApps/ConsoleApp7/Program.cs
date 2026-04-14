namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;
            do
            {
                Console.Write("Введите число (0 для выхода): ");
                input = int.Parse(Console.ReadLine());
                sum += input;
            } while (input != 0);
            Console.WriteLine($"Сумма всех введенных чисел: {sum}");
        }
    }
}
