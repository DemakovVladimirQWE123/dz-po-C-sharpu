namespace ConsoleApp9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 9";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.Write("Введите число: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("{0} - вот какое число Вы ввели", a);
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
