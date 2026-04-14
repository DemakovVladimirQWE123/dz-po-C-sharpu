namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N (десятичное): ");
            int decimalNum = int.Parse(Console.ReadLine());
            int num = decimalNum;
            string base5 = "";
            while (num > 0)
            {
                base5 = (num % 5) + base5;
                num /= 5;
            }
            Console.WriteLine($"{decimalNum} в десятичной СС = {base5} в пятеричной СС");
        }
    }
}
