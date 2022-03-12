using InvoicesApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicesApp.Helpers
{
    public static class AdminHelpers
    {
        public static void InvoicesPerCompany(Admin admin)
        {
            var companyInvoices = StaticDb.Users.Where(x => x.Role == Roles.Customer)
                                                .Select(x => (Customer)x)
                                                .SelectMany(x => x.Invoices)
                                                .Where(x => x.Company == admin.Company)
                                                .ToList();

            foreach (var companyInvoice in companyInvoices)
            {
                if (companyInvoice.InvoicePayedUnpayed == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Payed: {companyInvoice.InvoicePayedUnpayed}");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Payed: {companyInvoice.InvoicePayedUnpayed}");
                    Console.ResetColor();
                }
            }
        }
    }
}
