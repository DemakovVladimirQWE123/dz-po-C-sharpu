namespace ConsoleApp24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 24";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = int.Parse(Console.ReadLine());
			a = a * a;
			a = a * a;
			a = a * a;
			Console.WriteLine(a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
