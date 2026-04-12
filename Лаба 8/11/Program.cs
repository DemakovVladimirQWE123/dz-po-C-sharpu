namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            Console.Write("Введите слово для поиска: ");
            string word = Console.ReadLine();
            string content = File.ReadAllText(fileName);
            int count = 0;
            int late = 0;
            while ((late = content.IndexOf(word, late)) != -1)
            {
                count++;
                late += word.Length;
            }

            Console.WriteLine($"Слово \"{word}\" встречается {count} раз");
        }
    }
}