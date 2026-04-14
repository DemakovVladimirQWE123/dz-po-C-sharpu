namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N (десятичное): ");
            int decimalNum = int.Parse(Console.ReadLine());
            int num = decimalNum;
            string binary = "";
            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }
            Console.WriteLine($"{decimalNum} в десятичной СС = {binary} в двоичной СС");
        }
    }
}
