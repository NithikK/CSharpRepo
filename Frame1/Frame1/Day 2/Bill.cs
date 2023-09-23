using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_2
{
    public class Bill
    {
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
        public double Meds { get; set; }
        public double Gst { get; set; }
        public double Total { get; set; }

        public string String(){
            return "---------------------------------------------------------\n" +
            "                      Generated  Bill                    \n" +
            "---------------------------------------------------------\n" +
            $" ID : {this.Id}, Name : {Title} {FirstName} {LastName}, \n" + 
            $" Address : {Address}, City : {City}, State : {Region},\n" +
            $" Phone : {Phone}, Country : {Country}, Zip : {PostalCode}\n" +
            $" Date : {Date}, Time : {Time}\n" +
            $" Total Cost of Medicines : {Meds}\n" +
            $" gst                     : {Gst}\n" +
            $" Total Cost of Medicines : {Total}\n";
        }
    }
    internal class TestBill{
        public static void TestOne(){
            Bill bill_1 = new Bill();
            bill_1.Id = 1;
            bill_1.FirstName = "Nithik";
            bill_1.LastName = "K";
            bill_1.Title = "Mr.";
            bill_1.Address = "Vadapalani";
            bill_1.City = "Chennai";
            bill_1.Region = "Tamil Nadu";
            bill_1.PostalCode = "600093";
            bill_1.Country = "India";
            bill_1.Phone = "123456789";
            DateTime Now = DateTime.Now;
            bill_1.Date = Now.ToShortDateString();
            bill_1.Time = Now.ToShortTimeString();
            bill_1.Meds = 10000;            
            bill_1.Gst = bill_1.Meds * (5/100);
            bill_1.Total = bill_1.Meds + bill_1.Gst;
            String value = bill_1.String();
            System.Console.WriteLine(value);
        }
    }
}