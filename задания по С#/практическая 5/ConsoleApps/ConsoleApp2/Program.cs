namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 5. Проект 2";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			int a = 1;
			void Stroka (int a)
			{
				Console.WriteLine(a);
			}
			Stroka(a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
