using InvoicesApp.Enums;
using System;

namespace InvoicesApp
{
    public abstract class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public abstract Roles Role { get; set; }
        public double Balance { get; set; }
        public string Company { get; set; }

        public User(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }

        public User LogIn(string userName, string password)
        {
            if (UserName != userName)
            {
                return null;
            }

            if (Password != password)
            {
                throw new Exception("Invalid userName or password");
            }

            return this;
        }
    }
}
