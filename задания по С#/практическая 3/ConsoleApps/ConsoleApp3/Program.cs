namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 3";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            bool C = !(!A || !B) && B;
            Console.WriteLine($"не (не {A} или не {B}) и {B} = {C}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
