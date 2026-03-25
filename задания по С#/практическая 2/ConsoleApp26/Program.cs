namespace ConsoleApp26
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 26";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = int.Parse(Console.ReadLine());
			int b = a * a;
			int c = b * b;
			int d = c * c;
			a = b * d;
			Console.WriteLine(a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
