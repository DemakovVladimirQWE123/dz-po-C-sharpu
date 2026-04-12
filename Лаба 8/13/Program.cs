namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string resultFile = "result.txt";
            string cont1 = File.ReadAllText(file1);
            string cont2 = File.ReadAllText(file2);
            string comb = cont1 + cont2;
            File.WriteAllText(resultFile, comb);
            Console.WriteLine($"Содержимое файлов объединено! ");
            string a = File.ReadAllText(resultFile);
            Console.WriteLine(a);
        }
    }
}