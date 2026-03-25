namespace ConsoleApp18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 18";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("Введите R:");
			double R = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите r:");
			double r = double.Parse(Console.ReadLine());
			double p = Math.PI;
			double S = p * ((R * R) - (r * r));
			Console.WriteLine($"Площадь: {Math.Round(S,2)}");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}
