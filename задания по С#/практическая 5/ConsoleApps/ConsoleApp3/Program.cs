namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 5. Проект 3";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int n = int.Parse(Console.ReadLine());
			static void Stars(int n)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
						Console.Write('*');
					Console.WriteLine();
				}
			}
			Stars(n);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
