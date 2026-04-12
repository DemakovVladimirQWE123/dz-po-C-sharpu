using System;
using System.IO;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "book.txt";
            string outputFile = "filtered.txt";
            string[] lines = File.ReadAllLines(inputFile);
            string[] filteredLines = new string[lines.Length];
            int count = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length >= 5)
                {
                    filteredLines[count] = lines[i];
                    count++;
                }
            }
            Array.Resize(ref filteredLines, count);
            File.WriteAllLines(outputFile, filteredLines);
            string a = File.ReadAllText("filtered.txt");
            Console.WriteLine(a);
        }
    }
}