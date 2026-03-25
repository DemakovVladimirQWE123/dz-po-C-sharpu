namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 9";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение C (true/false): ");
            bool C = bool.Parse(Console.ReadLine());
            bool D = !(!A || B && C) || A;
            Console.WriteLine(D);
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
