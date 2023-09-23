using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int x = 10; nope

namespace Frame1.Day_2
{
    //int x = 10; nope
    internal class DemoA
    {
        int x = 10; //can be done since it is considered as Global / Member Variable / Class Variable / Field
        static int y = 20;
        public static void FirstMethod(){
            //Local Variable
            //int x=2000;
            int y = 5000;
            //Console.WriteLine(x); // Non static member can not be accessed
            System.Console.WriteLine(y);//Local var
            System.Console.WriteLine(DemoA.y);//global static var
        }
        public void SecondMethod(){
            //Local Variable
            int y = 5000;
            Console.WriteLine(x); // Non static member can be accessed
            System.Console.WriteLine(y);//Local var
            System.Console.WriteLine(DemoA.y);//global static var
        }
    }
    internal class DemoB
    {
    }
}

namespace Frame1.Gavs
{
    internal class DemoA
    {
    }
    internal class DemoB
    {
    }
}

/*
DemoA.FirstMethod();
//DemoA.SeconcMethod(); //Cannot call non static method


//to call non static methods create an object first
DemoA demoA_obj = new DemoA();
demoA_obj.SecondMethod();//stores address in heap for object demo_A_obj acts like reference
*/