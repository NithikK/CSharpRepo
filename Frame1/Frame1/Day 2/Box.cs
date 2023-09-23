using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_2
{
    internal class Box
    {
        public static int height;
        public int width;
        public const String type = "Wooden";
        //public const String type; // need to assign at declaration and cannot be changed throught the code
        public int GetHeight(){
            return height; //non static method can return static but vice versa doesnt work
        }
    }
    internal class TestBox
    {
        public static void TestOne(){
            //static members of a class can be accessed without an object reference
            Box.height = 100;
            //Box.width = 200;
            Box firstBox = new Box();
            Box secondBox = new Box();
            firstBox.width = 12345;
            secondBox.width = 98765;

            System.Console.WriteLine($"First Box = {firstBox.width}, {firstBox.GetHeight()}"); //$ to specify datatypes between strings
            System.Console.WriteLine($"Second Box = {secondBox.width}, {Box.height}");

            Box.height = 5555;

            System.Console.WriteLine($"First Box = {firstBox.width}, {firstBox.GetHeight()}"); //$ to specify datatypes between strings
            System.Console.WriteLine($"Second Box = {secondBox.width}, {Box.height}");
        }
    }
}