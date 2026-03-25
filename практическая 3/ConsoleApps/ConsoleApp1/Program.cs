namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 1   ";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите значение А (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());

            bool C1a = !(!A && !B) && A;
            Console.WriteLine($"а) не (не {A} и не {B}) и {A} = {C1a}");

            bool C1b = !(!A || !B) || A;
            Console.WriteLine($"б) не (не {A} или не {B}) или {A} = {C1b}");

            bool C1c = !(!A || !B) && B;
            Console.WriteLine($"в) не (не {A} или не {B}) и {B} = {C1c}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
