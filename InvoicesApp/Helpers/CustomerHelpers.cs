using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoicesApp.Helpers
{
    public static class CustomerHelpers
    {
        public static List<Invoice> ListAllInvoices(Customer customer)
        {
            var userInvoices = customer.Invoices;
            foreach (var invoice in userInvoices)
            {
                Console.WriteLine($"\nCompany: {invoice.Company} " +
                    $"\nMoneyOwed: {invoice.MoneyOwed}" +
                    $" \nIssued: {invoice.Issued}" +
                    $" \nDueDate: {invoice.DueDate}" +
                    $" \nInvoiceState:3 {invoice.InvoicePayedUnpayed}");
            }
            return userInvoices;
        }

        public static void IncreaseBalance(Customer customer)
        {
            Console.WriteLine("Please enter the amount of money you want to add to your balance:");
            string userMoney = Console.ReadLine();

            if (int.TryParse(userMoney, out int userMoneyParsed) && userMoneyParsed > 0)
            {
                customer.Balance += userMoneyParsed;
                Console.WriteLine($"Hello {customer.UserName} your current balance is {customer.Balance}");
            }
            else throw new Exception("Invalid amount");
        }

        public static void PayInvoice(Customer customer)
        {
            Console.WriteLine($"Hello {customer.UserName} which invoice would you like to pay?");

            var unPayedInvoices = customer.Invoices
                .Where(x => x.InvoicePayedUnpayed == false);
                
            foreach(var unPaidInvoice in unPayedInvoices)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{unPaidInvoice.Id}." +
                    $" \nCompany: {unPaidInvoice.Company}" +
                    $" \nMoneyOwed: {unPaidInvoice.MoneyOwed}" +
                    $" \nIssued: {unPaidInvoice.Issued}" +
                    $" \nDueDate: {unPaidInvoice.DueDate}" +
                    $" \nInvoiceState {unPaidInvoice.InvoicePayedUnpayed}");
                Console.ResetColor();
            }
           
            string invoicePick = Console.ReadLine();

            if (int.TryParse(invoicePick, out int invoicePickParsed))
            {
                var unPayedInvoice = unPayedInvoices.FirstOrDefault(x => x.Id == invoicePickParsed);
                if (unPayedInvoice == null)
                    throw new Exception("You chose incorectly");

                if (customer.Balance < unPayedInvoice.MoneyOwed)
                    throw new Exception("You dont have enough money to pay this invoice");

                if (unPayedInvoice.DueDate < DateTime.Now)
                    CalculatePenalty(unPayedInvoice, customer);

                var payedInvoice = customer.Balance - unPayedInvoice.MoneyOwed;
                customer.Balance = payedInvoice;

                Console.WriteLine($"{customer.UserName} your balance after paying this invoice is {customer.Balance} you payed {unPayedInvoice.MoneyOwed}");

                unPayedInvoice.InvoicePayedUnpayed = true;
                unPayedInvoice.MoneyOwed = 0;
            }
        }

        public static void CalculatePenalty(Invoice unPayedInvoice, Customer customer)
        {
            var daysOverdue = Math.Floor((DateTime.Now - unPayedInvoice.DueDate).TotalDays);
            var penalty = daysOverdue * 10;

            Console.WriteLine($"Hello {customer.UserName} unfortunatly you are overdoo {daysOverdue} days you will have to pay {penalty} extra");
            unPayedInvoice.MoneyOwed += penalty;
        }
    }
}
