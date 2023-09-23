using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frame1.Day_6;

namespace Frame1.Day_7
{
    internal class M_Bank
    {
        internal class Customer{
            internal class Customer_Detail{
                public int Id { get; set; }
                public string FirstName { get; set; } = string.Empty;
                public string LastName { get; set; } = string.Empty;
                public string Title { get; set; } = string.Empty;
                public string Address { get; set; } = string.Empty;
                public string City { get; set; } = string.Empty;
                public string Region { get; set; } = string.Empty;
                public string PostalCode { get; set; } = string.Empty;
                public string Country { get; set; } = string.Empty;
                public string Phone { get; set; } = string.Empty;
                public string Date { get; set; } = string.Empty;
                public string Time { get; set; } = string.Empty;
                public long Account_No { get; set; }
                public string Account_Type {get; set; } = string.Empty;
                public string Action {get; set; } = string.Empty;
            }
            internal class Customers_Account{
                public static void AddCustomer(){
                    
                }
                public static void RemoveCustomer(){}
                public static void ModifyCustomer(){}
            }
        }
        internal class Branches{
            public static void AddBranches(){}
            public static void RemoveBranches(){}
            public static void ModifyBranches(){}
        }
        internal class Account{
            internal class Savings{}
            internal class Current{}
            internal class Deposit{}
            internal class Withdraw{}
            internal class Balance{}
        }
        internal class AlertMessage{
            internal class Email{}
            internal class SMS{}
        }
        internal class TestBill{
            public static void TestOne(){
                Customer.Customer_Detail customer_1 = new Customer.Customer_Detail();
                customer_1.Id = 1;
                customer_1.FirstName = "Nithik";
                customer_1.LastName = "K";
                customer_1.Title = "Mr.";
                customer_1.Address = "Vadapalani";
                customer_1.City = "Chennai";
                customer_1.Region = "Tamil Nadu";
                customer_1.PostalCode = "600093";
                customer_1.Country = "India";
                customer_1.Phone = "123456789";
                DateTime Now = DateTime.Now;
                customer_1.Date = Now.ToShortDateString();
                customer_1.Time = Now.ToShortTimeString();
                customer_1.Account_No = 1123456789L;
                customer_1.Account_Type = "";
                customer_1.Action = "cnpwinc";
            }
        }
    }
}