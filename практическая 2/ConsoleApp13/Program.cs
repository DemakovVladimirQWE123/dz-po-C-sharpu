namespace ConsoleApp13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 13";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = 10;
			int b = 20;
			float c = (a + b) / 2;
			int r = a * b;
			Console.WriteLine($"Среднее арифметическое: {c}");
			double d = double.RootN(r,2);
			Console.WriteLine($"Среднее геометрическое: {d}");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
