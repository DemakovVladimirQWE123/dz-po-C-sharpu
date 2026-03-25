namespace ConsoleApp17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 17";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("Введите первый катет:");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Введите второй катет:");
			float b = float.Parse(Console.ReadLine());
			double c = Math.Sqrt((a * a) + (b * b));
			double d = Math.Round(c,2);
			Console.WriteLine(d);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
