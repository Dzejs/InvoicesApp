using InvoicesApp.Enums;
using System;

namespace InvoicesApp
{
    public class Admin : User
    {
        public override Roles Role { get; set; }

        public Admin(int id, string userName, string password, string company) : base(id, userName, password)
        {
            Role = Roles.Admin;
            Company = company;
        }
    }
}
