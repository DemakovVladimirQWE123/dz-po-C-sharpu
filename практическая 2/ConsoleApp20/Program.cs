namespace ConsoleApp20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 20";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = -10;
			int b = -20;
			double c = (Math.Abs(a) + Math.Abs(b)) / 2;
			Console.WriteLine(c);
			double d = Math.Round(Math.Sqrt(Math.Abs(a) * Math.Abs(b)),2);
			Console.WriteLine(d);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
