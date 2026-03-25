namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичкская 3. Проект 15";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("Радиус круга R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Сторона квадрата a: ");
            double a = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * R * R;
            double squareArea = a * a;

            if (circleArea > squareArea)
                Console.WriteLine("Площадь круга больше");
            else if (squareArea > circleArea)
                Console.WriteLine("Площадь квадрата больше");
            else
                Console.WriteLine("Площади равны");
            Console.Write("Введите любую клавишу...");
            Console.ReadKey();
        }
    }
}
