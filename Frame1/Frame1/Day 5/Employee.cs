using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_5
{
    public class Employee
    {
        private readonly double Id;
        public string Name;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Employee() { }
        public Employee(double v1)
        {
            Id = v1;
        }
        public double GetID()
        {
            return Id;
        }
        public static void EmpArray()
        {
            Employee[] elist = new Employee[10];
            for (int i = 0; i < 10; i++)
            {
                Employee e1 = new Employee(i);
                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }

    

            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                Employee e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }
    }
}