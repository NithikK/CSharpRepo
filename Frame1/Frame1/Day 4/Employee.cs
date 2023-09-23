using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Frame1.Day_4
{
    public enum City { Chennai, Banglore, Hyderabad, Pune }
    public enum Designation { Manager, Admin, Developer }
    public class Employee
    {
        public readonly int Eid;
        public string Ename;
        public City Ecity; //public String Ecity;
        public Designation JobTitle; //public String JobTitle
        public Employee(int v1){
            Eid = v1;
        }
        public String ToString(){
            String output = $"Details of a employee are : {Eid} {Ename} {Ecity} {JobTitle}";
            return output;
        }
    }
    class TestEmployee
    {
        public static void TestOne(){
            Employee e1 = new Employee(348);
            //e1.eid = 123
            e1.Ename = "John";
            e1.Ecity = City.Banglore; //ecity = "Chennai"; cannot do like this
            e1.JobTitle = Designation.Developer; //edept = "Testing";
            String output = e1.ToString();
            System.Console.WriteLine(output);
        }
    }
}