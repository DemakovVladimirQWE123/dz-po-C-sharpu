namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите один символ: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsDigit(a))
            {
                Console.WriteLine($"'{a}' это цифра.");
            }
            else if (char.IsLetter(a))
            {
                Console.WriteLine($"'{a}' это буква.");
            }
            else
            {
                Console.WriteLine($"'{a}' это символ.");
            }
        }
    }
}