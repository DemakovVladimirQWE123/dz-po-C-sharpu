namespace ConsoleApp28
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 28";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a, b, c;
			a = b = c = 2;
			double z = a * b + (double)c++ / (b - a * b * --c);
			double x = (a * b + c++) / (b - a * b * --c);
			double v = a * b + c++ / (b - a * b) * --c;
			double n = a * (b + c++ / b) - a * b * --c;
			double m = a * (b + c++) / b - a * b * --c;
			Console.WriteLine(Math.Round(z,2));
            Console.WriteLine(x);
            Console.WriteLine(v);
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
