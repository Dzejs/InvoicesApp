using InvoicesApp.Enums;
using System;
using System.Collections.Generic;

namespace InvoicesApp
{
    public class Customer : User
    {
        public List<Invoice> Invoices { get; set; }
        public override Roles Role { get; set; }

        public Customer(int id, string userName, string password, double balance, List<Invoice> invoices) : base(id, userName, password)
        {
            Role = Roles.Customer;
            Balance = balance;
            Invoices = invoices;
        }
    }
}
