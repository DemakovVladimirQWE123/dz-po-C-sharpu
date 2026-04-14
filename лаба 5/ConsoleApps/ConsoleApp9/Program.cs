namespace ConsoleApp9
{
    using System;

    class Task9
    {
        static void PrintDigits(int n)
        {
            // Обработка отрицательных чисел
            if (n < 0)
            {
                Console.Write("- ");
                n = -n;
            }

            // Собираем цифры в обратном порядке
            int temp = n;
            int digits = 0;
            int reversed = 0;
            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
                digits++;
            }

            // Выводим цифры в правильном порядке
            for (int i = 0; i < digits; i++)
            {
                Console.Write(reversed % 10 + " ");
                reversed /= 10;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Цифры числа: ");
            PrintDigits(n);
        }
    }
}
