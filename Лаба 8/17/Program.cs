using System.Data;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите математическое выражение: ");
            string expression = Console.ReadLine();
            object result = new DataTable().Compute(expression, null);
            Console.WriteLine($"Результат: {result}");
        }
    }
}