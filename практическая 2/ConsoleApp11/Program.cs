namespace ConsoleApp11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 11";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("7  15  100");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
