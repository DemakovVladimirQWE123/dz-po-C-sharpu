namespace ConsoleApp19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 19";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = 3;
			int b = 4;
			double c = Math.Sqrt((a * a) + (b * b));
			double d = a + b + c;
			Console.WriteLine(d);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
