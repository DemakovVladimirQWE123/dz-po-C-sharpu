namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int word = words.Length;
            Console.WriteLine($"Ответ: {word}");
        }
    }
}