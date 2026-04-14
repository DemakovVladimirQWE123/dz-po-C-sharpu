namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
                userNum = int.Parse(Console.ReadLine());
            } while (userNum < 1 || userNum > 100);
            Console.WriteLine($"Вы ввели корректное число: {userNum}");
        }
    }
}
