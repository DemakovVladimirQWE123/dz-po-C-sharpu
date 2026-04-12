namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "book.txt";
            string[] lines = File.ReadAllLines(fileName);
            int lineCount = lines.Length;
            string fullText = File.ReadAllText(fileName);
            int Symvol = fullText.Length;
            int wordCount = 0;
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                foreach (string w in words)
                {
                    if (w.Length > 0)
                        wordCount++;
                }
            }
            Console.WriteLine($"Символов: {Symvol}");
            Console.WriteLine($"Слов: {wordCount}");
            Console.WriteLine($"Строк: {lineCount}");
        }
    }
}