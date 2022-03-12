using InvoicesApp.Enums;
using InvoicesApp.Helpers;
using System;

namespace InvoicesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var user = UserHelpers.LogIn();

                    if (user.Role == Roles.Customer)
                    {
                        if (user == null)
                            throw new Exception("User not found");
                        else
                        {
                            Console.WriteLine("\n1.Balance \n2.Invoices \n3.Increase Balance \n4.Pay Invoice");
                            string customerPick = Console.ReadLine();

                            if (int.TryParse(customerPick, out int userPickParsed))
                            {
                                if (userPickParsed == ((int)CustomerEnums.Balance))
                                    Console.WriteLine($"Hello {user.UserName} your balance is {user.Balance}");

                                else if (userPickParsed == ((int)CustomerEnums.Invoices))
                                    CustomerHelpers.ListAllInvoices((Customer)user);

                                else if (userPickParsed == ((int)CustomerEnums.IncreaseBalace))
                                    CustomerHelpers.IncreaseBalance((Customer)user);

                                else if (userPickParsed == ((int)CustomerEnums.PayInvoice))
                                    CustomerHelpers.PayInvoice((Customer)user);

                                else throw new Exception("Invalid pick!");
                            }
                        }
                    }
                    else if (user.Role == Roles.Admin)
                    {
                        AdminHelpers.InvoicesPerCompany((Admin)user);
                    }
                    else throw new Exception("Invalid pick!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
