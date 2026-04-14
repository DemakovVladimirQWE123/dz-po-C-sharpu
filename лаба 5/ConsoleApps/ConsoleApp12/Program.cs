namespace ConsoleApp12
{
    using System;

    class Task12
    {
        static int GetNumberInRange()
        {
            int num;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);
            return num;
        }

        static void Main()
        {
            int number = GetNumberInRange();
            Console.WriteLine($"Вы ввели: {number}");
        }
    }
}
