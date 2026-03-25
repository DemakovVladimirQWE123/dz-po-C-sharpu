namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 2";
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

            Console.WriteLine($"а) не (А или не В и С) = {!(A || !B && C)}");
            Console.WriteLine($"б) А и не (В и А или не С) = {A && !(B && A || !C)}");
            Console.WriteLine($"в) не (не А или В и С) = {!(!A || B && C)}");
            Console.WriteLine($"г) не (А или не В и С) или С = {!(A || !B && C) || C}");
            Console.WriteLine($"д) не (А и не В или С) и В = {!(A && !B || C) && B}");
            Console.WriteLine($"е) не (не А или В и С) или А = {!(!A || B && C) || A}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
