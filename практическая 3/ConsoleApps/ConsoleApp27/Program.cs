namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 27";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Номер месяца m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Число n: ");
            int n = int.Parse(Console.ReadLine());

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int prevMonth = m, prevDay = n - 1;
            if (prevDay == 0)
            {
                prevMonth--;
                if (prevMonth == 0) prevMonth = 12;
                prevDay = daysInMonth[prevMonth - 1];
            }
            Console.WriteLine($"Предыдущий день: {prevDay}.{prevMonth}");

            int nextMonth = m, nextDay = n + 1;
            if (nextDay > daysInMonth[m - 1])
            {
                nextMonth++;
                if (nextMonth > 12) nextMonth = 1;
                nextDay = 1;
            }
            Console.WriteLine($"Следующий день: {nextDay}.{nextMonth}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
