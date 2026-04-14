namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двоичное число: ");
            string binaryNum = Console.ReadLine();
            int decimalResult = 0;
            int power = 0;
            int binaryTemp = int.Parse(binaryNum);
            while (binaryTemp > 0)
            {
                int lastDigit = binaryTemp % 10;
                decimalResult += lastDigit * (int)Math.Pow(2, power);
                binaryTemp /= 10;
                power++;
            }
            Console.WriteLine($"{binaryNum} в двоичной СС = {decimalResult} в десятичной СС");
        }
    }
}
