namespace ConsoleApp21
{
    using System;

    class Task21
    {
        static int Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
                result *= number;
            return result;
        }

        static void Main()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num}^{pow} = {Power(num, pow)}");
        }
    }
}
