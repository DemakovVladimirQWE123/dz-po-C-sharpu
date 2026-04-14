namespace _2._4
{
    using System;

    namespace Task2_4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int randomNum;
                int attempts = 0;
                Console.Write("Сгенерированные числа: ");
                do
                {
                    randomNum = rnd.Next(1, 11);
                    Console.Write(randomNum + " ");
                    attempts++;
                } while (randomNum != 7);
                Console.WriteLine($"\nЧисло 7 получено после {attempts} попыток");
            }
        }
    }
}
