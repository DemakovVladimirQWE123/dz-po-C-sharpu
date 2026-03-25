namespace ConsoleApp12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 12";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			float z; int a = 1, b = 2, c = 3;
			const int m = 3;
			z = (a + b + c) / m;
			Console.WriteLine($"Ответ: {z}");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
