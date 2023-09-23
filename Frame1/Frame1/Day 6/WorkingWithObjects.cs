using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frame1.Day_4;

namespace Frame1.Day_6
{
    public class WorkingWithObjects
    {
        
        public static void TestOne() 
        { 
            Object objectOne=new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");
        
            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Sam";
            Emp empTwo = new Emp();
            empTwo.ID = 1002; empTwo.Name = "Sam";
            Emp empThree = new Emp();
            empThree.ID = 103; empThree.Name = "Sam";
            bool flag = (empOne.Equals(empTwo));
            System.Console.WriteLine(flag);
            flag = empOne.Equals(empThree);
            System.Console.WriteLine(flag);
            System.Console.WriteLine(empThree);
            System.Console.WriteLine(flag);
            System.Console.WriteLine(empOne.GetHashCode());
            System.Console.WriteLine(empTwo.GetHashCode());
            System.Console.WriteLine(empThree.GetHashCode());
        }
    }
}