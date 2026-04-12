namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string num = "0123456789";
            string a = "abcdefghijklmnopqrstuvwxyz";
            string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string all = num + a + A;
            string password = "";
            for (int i = 0; i < 8; i++)
            {
                int index = rand.Next(all.Length);
                password += all[index];
            }

            Console.WriteLine($"Пароль: {password}");
        }
    }
}