namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в семеричной СС: ");
            string base7Num = Console.ReadLine();
            int decimalResult = 0;
            int power = 0;
            int base7Temp = int.Parse(base7Num);
            while (base7Temp > 0)
            {
                int lastDigit = base7Temp % 10;
                decimalResult += lastDigit * (int)Math.Pow(7, power);
                base7Temp /= 10;
                power++;
            }
            Console.WriteLine($"{base7Num} в семеричной СС = {decimalResult} в десятичной СС");
        }
    }
}
