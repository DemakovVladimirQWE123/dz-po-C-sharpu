namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int code = (int)a;
            Console.WriteLine($"Код символа '{a}': {code}");
        }
    }
}