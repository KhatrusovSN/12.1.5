namespace _12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание списка пользователей.
            List<User> users = new List<User>()
            {
                new User{ Login = "qwerty1", Name = "Петр Петров", IsPremium = true },
                new User{ Login = "qwerty2", Name = "Александр Александров", IsPremium = false },
                new User{ Login = "qwerty3", Name = "Сергей Николаевич", IsPremium = false }
            };

            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    Console.WriteLine($"Hello, {user.Name}");

                    if (!user.IsPremium)
                    {
                        User.ShowAds();
                    }
                }
            }
        }
    }
}