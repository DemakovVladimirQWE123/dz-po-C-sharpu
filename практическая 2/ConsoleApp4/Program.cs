namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 4";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = 3;
			double b = 2.6;
			b = a + b;
			Console.WriteLine(b);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}