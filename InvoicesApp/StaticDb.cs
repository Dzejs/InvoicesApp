using System;
using System.Collections.Generic;

namespace InvoicesApp
{
    public static class StaticDb
    {
        public static List<User> Users = new List<User>()
        {
             new Customer(1, "Bob", "Bob123", 2000, new List<Invoice>{
                        new Invoice
                        {
                            Id = 1,
                            Company = "BEG",
                            MoneyOwed = 550,
                            DueDate = new DateTime(2022, 4, 15),
                            Issued = new DateTime(2022, 3, 1),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 2,
                            Company = "EVN",
                            MoneyOwed = 900,
                            DueDate = new DateTime(2022, 2, 10),
                            Issued = new DateTime(2021, 3, 1),
                            InvoicePayedUnpayed = true
                        },
                        new Invoice
                        {
                            Id = 3,
                            Company = "Vodovod ",
                            MoneyOwed = 1200,
                            DueDate = new DateTime(2022, 5, 28),
                            Issued = new DateTime(2022, 4, 18),
                            InvoicePayedUnpayed = false
                        }
                }),
             new Customer(2, "Jill", "Jill123", 2500, new List<Invoice>{
                         new Invoice
                        {
                            Id = 1,
                            Company = "BEG",
                            MoneyOwed = 900,
                            DueDate = new DateTime(2022, 4, 15),
                            Issued = new DateTime(2022, 3, 1),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 2,
                            Company = "EVN",
                            MoneyOwed = 500,
                            DueDate = new DateTime(2022, 7, 22),
                            Issued = new DateTime(2022, 3, 26),
                            InvoicePayedUnpayed = true
                        },
                        new Invoice
                        {
                            Id = 3,
                            Company = "Vodovod ",
                            MoneyOwed = 1200,
                            DueDate = new DateTime(2022, 2, 12),
                            Issued = new DateTime(2022, 1, 18),
                            InvoicePayedUnpayed = false
                        }
                }),
             new Customer(3, "Wayne", "Wayne123", 3000, new List<Invoice>{
                        new Invoice
                        {
                            Id = 1,
                            Company = "BEG",
                            MoneyOwed = 200,
                            DueDate = new DateTime(2022, 7, 5),
                            Issued = new DateTime(2022, 6, 2),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 2,
                            Company = "EVN",
                            MoneyOwed = 500,
                            DueDate = new DateTime(2022, 10, 5),
                            Issued = new DateTime(2022, 9, 25),
                            InvoicePayedUnpayed = true
                        },
                        new Invoice
                        {
                            Id = 3,
                            Company = "Vodovod ",
                            MoneyOwed = 1200,
                            DueDate = new DateTime(2022, 12, 18),
                            Issued = new DateTime(2022, 11, 26),
                            InvoicePayedUnpayed = false
                        }
                }),
             new Customer(4, "Marli", "Marli123", 3500, new List<Invoice>{
                        new Invoice
                        {
                            Id = 1,
                            Company = "BEG",
                            MoneyOwed = 900,
                            DueDate = new DateTime(2022, 4, 15),
                            Issued = new DateTime(2022, 3, 1),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 2,
                            Company = "EVN",
                            MoneyOwed = 500,
                            DueDate = new DateTime(2022, 7, 22),
                            Issued = new DateTime(2022, 3, 26),
                            InvoicePayedUnpayed = true
                        },
                        new Invoice
                        {
                            Id = 3,
                            Company = "Vodovod ",
                            MoneyOwed = 1200,
                            DueDate = new DateTime(2022, 2, 12),
                            Issued = new DateTime(2022, 1, 18),
                            InvoicePayedUnpayed = false
                        }
                }),
             new Customer(5, "Tresh", "Tresh123", 1000, new List<Invoice> {
                        new Invoice
                        {
                            Id = 1,
                            Company = "BEG",
                            MoneyOwed = 900,
                            DueDate = new DateTime(2022, 4, 15),
                            Issued = new DateTime(2022, 3, 1),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 2,
                            Company = "EVN",
                            MoneyOwed = 500,
                            DueDate = new DateTime(2022, 7, 22),
                            Issued = new DateTime(2022, 3, 26),
                            InvoicePayedUnpayed = false
                        },
                        new Invoice
                        {
                            Id = 3,
                            Company = "Vodovod ",
                            MoneyOwed = 1200,
                            DueDate = new DateTime(2022, 2, 12),
                            Issued = new DateTime(2022, 1, 18),
                            InvoicePayedUnpayed = false
                    }

                }),

             new Admin(1, "Jayce", "Jaynce123", "BEG"),
             new Admin(2, "Martin", "Martin123", "EVN"),
             new Admin(3, "Stefan", "Stefan123", "Vodovod")

        };


        //public static List<Customer> Customers = new List<Customer>()
        //    {
        //        new Customer(1, "Bob", "Bob123", 2000, new List<Invoice>{
        //                new Invoice
        //                {
        //                    Id = 1,
        //                    Company = "BEG",
        //                    MoneyOwed = 550,
        //                    DueDate = new DateTime(2022, 4, 15),
        //                    Issued = new DateTime(2022, 3, 1),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 2,
        //                    Company = "EVN",
        //                    MoneyOwed = 900,
        //                    DueDate = new DateTime(2022, 2, 10),
        //                    Issued = new DateTime(2021, 3, 1),
        //                    InvoicePayedUnpayed = true
        //                },
        //                new Invoice
        //                {
        //                    Id = 3,
        //                    Company = "Vodovod ",
        //                    MoneyOwed = 1200,
        //                    DueDate = new DateTime(2022, 5, 28),
        //                    Issued = new DateTime(2022, 4, 18),
        //                    InvoicePayedUnpayed = false
        //                }
        //        }),
        //        new Customer(2, "Jill", "Jill123", 2500, new List<Invoice>{
        //                 new Invoice
        //                {
        //                    Id = 1,
        //                    Company = "BEG",
        //                    MoneyOwed = 900,
        //                    DueDate = new DateTime(2022, 4, 15),
        //                    Issued = new DateTime(2022, 3, 1),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 2,
        //                    Company = "EVN",
        //                    MoneyOwed = 500,
        //                    DueDate = new DateTime(2022, 7, 22),
        //                    Issued = new DateTime(2022, 3, 26),
        //                    InvoicePayedUnpayed = true
        //                },
        //                new Invoice
        //                {
        //                    Id = 3,
        //                    Company = "Vodovod ",
        //                    MoneyOwed = 1200,
        //                    DueDate = new DateTime(2022, 2, 12),
        //                    Issued = new DateTime(2022, 1, 18),
        //                    InvoicePayedUnpayed = false
        //                }
        //        }),
        //        new Customer(3, "Wayne", "Wayne123", 3000, new List<Invoice>{
        //                new Invoice
        //                {
        //                    Id = 1,
        //                    Company = "BEG",
        //                    MoneyOwed = 200,
        //                    DueDate = new DateTime(2022, 7, 5),
        //                    Issued = new DateTime(2022, 6, 2),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 2,
        //                    Company = "EVN",
        //                    MoneyOwed = 500,
        //                    DueDate = new DateTime(2022, 10, 5),
        //                    Issued = new DateTime(2022, 9, 25),
        //                    InvoicePayedUnpayed = true
        //                },
        //                new Invoice
        //                {
        //                    Id = 3,
        //                    Company = "Vodovod ",
        //                    MoneyOwed = 1200,
        //                    DueDate = new DateTime(2022, 12, 18),
        //                    Issued = new DateTime(2022, 11, 26),
        //                    InvoicePayedUnpayed = false
        //                }
        //        }),
        //        new Customer(4, "Marli", "Marli123", 3500, new List<Invoice>{
        //                new Invoice
        //                {
        //                    Id = 1,
        //                    Company = "BEG",
        //                    MoneyOwed = 900,
        //                    DueDate = new DateTime(2022, 4, 15),
        //                    Issued = new DateTime(2022, 3, 1),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 2,
        //                    Company = "EVN",
        //                    MoneyOwed = 500,
        //                    DueDate = new DateTime(2022, 7, 22),
        //                    Issued = new DateTime(2022, 3, 26),
        //                    InvoicePayedUnpayed = true
        //                },
        //                new Invoice
        //                {
        //                    Id = 3,
        //                    Company = "Vodovod ",
        //                    MoneyOwed = 1200,
        //                    DueDate = new DateTime(2022, 2, 12),
        //                    Issued = new DateTime(2022, 1, 18),
        //                    InvoicePayedUnpayed = false
        //                }
        //        }),
        //        new Customer(5, "Tresh", "Tresh123", 1000, new List<Invoice> {
        //                new Invoice
        //                {
        //                    Id = 1,
        //                    Company = "BEG",
        //                    MoneyOwed = 900,
        //                    DueDate = new DateTime(2022, 4, 15),
        //                    Issued = new DateTime(2022, 3, 1),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 2,
        //                    Company = "EVN",
        //                    MoneyOwed = 500,
        //                    DueDate = new DateTime(2022, 7, 22),
        //                    Issued = new DateTime(2022, 3, 26),
        //                    InvoicePayedUnpayed = false
        //                },
        //                new Invoice
        //                {
        //                    Id = 3,
        //                    Company = "Vodovod ",
        //                    MoneyOwed = 1200,
        //                    DueDate = new DateTime(2022, 2, 12),
        //                    Issued = new DateTime(2022, 1, 18),
        //                    InvoicePayedUnpayed = false
        //            }

        //        })
        //    };

        //public static List<Admin> Admins = new List<Admin>()
        //    {
        //        new Admin(1, "Jayce", "Jaynce123", "BEG"),
        //        new Admin(2, "Martin", "Martin123", "EVN"),
        //        new Admin(3, "Stefan", "Stefan123", "Vodovod")
        //    };
    }
}
