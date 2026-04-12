namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Что заменить: ");
            string old = Console.ReadLine();
            Console.Write("На что заменить: ");
            string newe = Console.ReadLine();
            string result = text.Replace(old, newe);
            Console.WriteLine($"Результат: {result}");
        }
    }
}