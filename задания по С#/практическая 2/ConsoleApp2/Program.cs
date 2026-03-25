namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Практическая 2. Проект 2";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("Введи первое число:");
			int one = int.Parse(Console.ReadLine());
			Console.WriteLine("Введи второе число:");
			int two = int.Parse(Console.ReadLine());
			Random rnd = new Random();
			int result = rnd.Next(one, two + 1);
			Console.WriteLine($"Ответ: {result}");
			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}