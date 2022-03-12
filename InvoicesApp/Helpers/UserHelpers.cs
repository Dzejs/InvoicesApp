using System;
using System.Linq;

namespace InvoicesApp.Helpers
{
    public static class UserHelpers
    {
        public static User LogIn()
        {
            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            var user = StaticDb.Users.FirstOrDefault(x => x.LogIn(userName, password) != null);
            if (user == null)
                throw new Exception("Invalid username or password");

            return user;
        }
    }
}
