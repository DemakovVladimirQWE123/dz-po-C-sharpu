namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму N: ");
            double deposit = double.Parse(Console.ReadLine());
            double target = 100000;
            int months = 0;
            double current = deposit;
            while (current < target)
            {
                current += current * 0.02;
                months++;
            }
            Console.WriteLine($"Через {months} месяцев гражданин накопит {target} рублей");
        }
    }
}
