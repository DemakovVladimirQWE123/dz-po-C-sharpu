namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine($"Ответ: {reversed}");
        }
    }
}
// ОХ уж эти нейронки, с 1 В 1 ЗАДАНИЯМИ из прошлого номера!