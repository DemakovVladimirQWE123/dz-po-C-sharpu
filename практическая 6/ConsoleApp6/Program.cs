namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 6. Задание 6";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            int[] prices = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < prices.Length; i++)
                prices[i] = rnd.Next(20, 301);

            int minPrice = prices[0];
            int minIndex = 0;
            for (int i = 1; i < prices.Length; i++)
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    minIndex = i;
                }

            Console.WriteLine("Цены: " + string.Join(" ", prices));
            Console.WriteLine($"Самый дешевый товар: {minPrice} руб., порядковый номер: {minIndex + 1}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
