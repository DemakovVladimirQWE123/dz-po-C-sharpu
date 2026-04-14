namespace ConsoleApp11
{
    using System;

    class Task11
    {
        static int ConvertToDecimal(string number, int fromBase)
        {
            int result = 0;
            int power = 0;
            // Обрабатываем строку справа налево
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                if (digit >= fromBase)
                    throw new ArgumentException("Недопустимая цифра для данной системы счисления.");
                result += digit * (int)Math.Pow(fromBase, power);
                power++;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Введите число: ");
            string numStr = Console.ReadLine();
            Console.Write("Введите основание исходной системы (2-10): ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Десятичное значение: {ConvertToDecimal(numStr, b)}");
        }
    }
}