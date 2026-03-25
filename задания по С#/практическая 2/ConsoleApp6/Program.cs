namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 6";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			decimal a = 0.0228m;
			Console.WriteLine(a);
			Console.WriteLine(Math.Round(a, 3));
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
