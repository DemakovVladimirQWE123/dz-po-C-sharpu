namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "secret.txt";
            string output = "encrypted.txt";
            string text = File.ReadAllText(input);
            string encrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c))
                    encrypted += '*';
                else
                    encrypted += c;
            }
            File.WriteAllText(output, encrypted);
            Console.WriteLine($"Готово!");
            string a = File.ReadAllText("encrypted.txt");
            Console.WriteLine(a);
        }
    }
}