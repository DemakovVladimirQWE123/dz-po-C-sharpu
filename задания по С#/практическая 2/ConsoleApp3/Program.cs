namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 3";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			float a = 3.2f;
			decimal b = 2.6m;
			double c = 4.5;
			c += a + (float)b;
			Console.WriteLine(c);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}