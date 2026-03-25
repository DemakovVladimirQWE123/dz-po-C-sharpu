using System;

namespace ConsoleApp16
{
	internal class Program
	{
		static void Main()
		{
			Console.Title = "Практическая 2. Проект 16";
			Console.WindowWidth = 60;
			Console.WindowHeight = 13;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(0, 0);

			Console.WriteLine("Введите коэффициент a:");
			float a = float.Parse(Console.ReadLine());

			if (a == 0)
			{
				Console.WriteLine("Это не квадратное уравнение!");
				return;
			}

			Console.WriteLine("Введите коэффициент b:");
			float b = float.Parse(Console.ReadLine());

			Console.WriteLine("Введите коэффициент c:");
			float c = float.Parse(Console.ReadLine());

			double D = Math.Pow(b, 2) - 4 * a * c;

			if (D > 0)
			{
				double sqrtD = Math.Sqrt(D);
				double x1 = (-b + sqrtD) / (2 * a);
				double x2 = (-b - sqrtD) / (2 * a);
				Console.WriteLine($"Корни уравнения: x1={x1:F2}, x2={x2:F2}");
			}
			else if (D == 0)
			{
				double x = -b / (2 * a);
				Console.WriteLine($"Единственный корень уравнения: x={x:F2}");
			}
			else
			{
				Console.WriteLine("Действительных корней нет.");
			}

			Console.Write("Введите любую клавишу...");
			Console.ReadKey();
		}
	}
}