using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicesApp
{
    public class Invoice
    {
        public int Id { get;set; }
        public string Company { get; set; }
        public double MoneyOwed { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Issued { get; set; }
        public bool InvoicePayedUnpayed { get; set; }
    }
}
