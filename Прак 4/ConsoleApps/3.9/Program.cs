namespace _3._9
{
    using System;

    namespace Task3_9
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double position = 0;   // положение относительно дома
                double totalPath = 0;  // общий пройденный путь
                int direction = 1;     // 1 – вперёд, -1 – назад

                for (int i = 1; i <= 100; i++)
                {
                    double step = 1.0 / i;
                    position += direction * step;
                    totalPath += step;
                    direction *= -1;
                }

                Console.WriteLine($"а) Расстояние от дома после 100-го этапа: {Math.Abs(position)} км");
                Console.WriteLine($"б) Общий пройденный путь: {totalPath} км");
            }
        }
    }
}
