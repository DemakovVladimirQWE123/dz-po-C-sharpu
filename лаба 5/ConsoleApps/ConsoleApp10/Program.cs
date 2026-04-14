namespace ConsoleApp10
{
    using System;

    class Task10
    {
        static string ConvertFromDecimal(int number, int toBase)
        {
            if (number == 0) return "0";
            string result = "";
            int n = number;
            while (n > 0)
            {
                result = (n % toBase) + result;
                n /= toBase;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Введите число в десятичной системе: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите основание новой системы (2-10): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {ConvertFromDecimal(num, b)}");
        }
    }
}
