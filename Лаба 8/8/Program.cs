namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку с цифрами: ");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
}