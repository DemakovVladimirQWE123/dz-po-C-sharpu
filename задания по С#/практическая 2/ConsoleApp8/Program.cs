namespace ConsoleApp8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 8";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.Write("Введите число: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Вы ввели число {0}", a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
