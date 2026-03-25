namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая 3. Проект 5";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine($"а) каждое из чисел А и В больше 100: {A > 100 && B > 100}");
            Console.WriteLine($"б) хотя бы одно из чисел А и В положительное: {A > 0 || B > 0}");
            Console.WriteLine($"в) каждое из чисел А, В, С кратно трем: {A % 3 == 0 && B % 3 == 0 && C % 3 == 0}");
            bool onlyOneLess50 = (A < 50 && B >= 50 && C >= 50) ||
                                 (B < 50 && A >= 50 && C >= 50) ||
                                 (C < 50 && A >= 50 && B >= 50);
            Console.WriteLine($"г) только одно из чисел А, В и С меньше 50: {onlyOneLess50}");
            Console.WriteLine($"д) хотя бы одно из чисел А, В, С отрицательно: {A < 0 || B < 0 || C < 0}");

            Console.Write("Введите число X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine($"е) каждое из чисел X и Y нечетное: {X % 2 != 0 && Y % 2 != 0}");
            bool onlyOneLess20 = (X < 20 && Y >= 20) || (Y < 20 && X >= 20);
            Console.WriteLine($"ж) только одно из чисел X и Y меньше 20: {onlyOneLess20}");
            Console.WriteLine($"з) хотя бы одно из чисел X и Y равно нулю: {X == 0 || Y == 0}");

            Console.Write("Введите число Z: ");
            int Z = int.Parse(Console.ReadLine());

            Console.WriteLine($"и) каждое из чисел X, Y, Z отрицательное: {X < 0 && Y < 0 && Z < 0}");
            bool onlyOneMultipleOf5 = (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) ||
                                      (Y % 5 == 0 && X % 5 != 0 && Z % 5 != 0) ||
                                      (Z % 5 == 0 && X % 5 != 0 && Y % 5 != 0);
            Console.WriteLine($"к) только одно из чисел X, Y и Z кратно пяти: {onlyOneMultipleOf5}");
            Console.WriteLine($"л) хотя бы одно из чисел X, Y, Z больше 100: {X > 100 || Y > 100 || Z > 100}");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
