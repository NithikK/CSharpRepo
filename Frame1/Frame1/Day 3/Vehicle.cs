using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    //it is not complesory for an abstract class to have abstract method
    //cannot be instantiated
    //must be inherited
    internal abstract class Vehicle
    {
        public Vehicle(){
            System.Console.WriteLine("Vehical Constructor");
        }
        public void Start(){
            System.Console.WriteLine("Vehicle Started");
        }
    }
    internal class Car : Vehicle{
        public Car(){
            System.Console.WriteLine("Car Constructor");
        }
    }
    class VehicleTester{
        public static void TestOne(){
            Vehicle tester = new Car();
            tester.Start();
        }
    }
}