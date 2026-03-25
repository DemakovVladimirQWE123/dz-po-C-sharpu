namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 5";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.Write("Введите число: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine(a*a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}