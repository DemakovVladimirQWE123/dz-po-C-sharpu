namespace ConsoleApp15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 15";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			float x = 0;
			Console.WriteLine("Введите a:");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Введите b:");
			float b = float.Parse(Console.ReadLine());
			if (a != 0)
			{
				x = -(b / a);
				Console.WriteLine(x);
			}
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
