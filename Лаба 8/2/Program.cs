namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char converted;
            if (char.IsUpper(a))
                converted = char.ToLower(a);
            else
                converted = char.ToUpper(a);
            Console.WriteLine($"Ответ: {converted}");
        }
    }
}