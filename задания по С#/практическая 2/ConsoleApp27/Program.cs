namespace ConsoleApp27
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 27";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = int.Parse(Console.ReadLine());
			int b = 0;
			int c = 1;
			while (a > 0)
			{
				int d = a % 10;
				b = b + d;
				c = c * d;
				a = a / 10;
				Console.WriteLine(c);
			}
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
