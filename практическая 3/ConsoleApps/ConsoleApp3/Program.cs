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
            Console.Write("Введите значение X (true/false): ");
            bool X = bool.Parse(Console.ReadLine());
            Console.Write("Введите значение Y (true/false): ");
            bool Y = bool.Parse(Console.ReadLine());

            bool imp = (!X || Y) && (!Y || X);
            Console.WriteLine($"а) (x ∨ y) → (у ≡ x) = {(X || Y ? imp : true)}");

            Console.WriteLine($"б) (x ∨ y) ≡ (у ∧ x) = {(X || Y) == (Y && X)}");
            Console.WriteLine($"в) (x ∧ y) ∨ (у → x) = {(X && Y) || (!Y || X)}");
            Console.WriteLine($"г) (x ≡ y) → у = {(X == Y ? true : Y)}");

            Console.Write("Введите значение Z (true/false): ");
            bool Z = bool.Parse(Console.ReadLine());

            Console.WriteLine($"д) (x ∨ y) → (z ≡ x) = {(!(X || Y) || (Z == X)) && (!(Z == X) || (X || Y))}");
            Console.WriteLine($"е) (x ≡ (z ∨ y)) ∨ ((x→ z) ∧ (y → x)) = {(X == (Z || Y)) || ((!X || Z) && (!Y || X))}");
            Console.WriteLine($"ж) y → (z ≡ x) = {(!Y || (Z == X)) && (!(Z == X) || Y)}");
            Console.WriteLine($"з) x ≡ (y → z) = {X == (!Y || Z)}"); Console.Write("Введите значение X (true/false): ");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
