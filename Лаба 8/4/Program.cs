namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char Sogl = char.ToLower(a);
            bool Glass = Sogl == 'a' || Sogl == 'e' || Sogl == 'i' ||
                           Sogl == 'o' || Sogl == 'u' || Sogl == 'y';

            if (Glass)
                Console.WriteLine($"'{a}' гласная.");
            else
                Console.WriteLine($"'{a}' согласная.");
        }
    }
}