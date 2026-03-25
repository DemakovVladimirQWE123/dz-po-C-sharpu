namespace ConsoleApp14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 14";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			double m = 15.6;
			float V = 9;
			double p = m / V;
			Console.WriteLine($"Плотность: {Math.Round(p,2)}");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
