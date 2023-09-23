using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_2
{
    public class Person
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

        public override string ToString(){
            return $" ID : {this.Id}, Name : {Title} {FirstName} {LastName}, \n" + 
            $" Address : {Address}, City : {City}, State : {Region},\n" +
            $" Phone : {Phone}, Country : {Country}, Zip : {PostalCode}\n";
        }
    }
    internal class TestPerson{
        public static void TestOne(){
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Nithik";
            firstPerson.LastName = "K";
            firstPerson.Title = "Mr.";
            firstPerson.Address = "Vadapalani";
            firstPerson.City = "Chennai";
            firstPerson.Region = "Tamil Nadu";
            firstPerson.PostalCode = "600093";
            firstPerson.Country = "India";
            firstPerson.Phone = "123456789";
            String value = firstPerson.ToString();
            System.Console.WriteLine(value);
        }
    }
}