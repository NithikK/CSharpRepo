using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    internal class Box
    {
        public int height;
        public int width;
        public int length;
        public Box(int x){ //Constructor // parent needs parameter less constructor to create a child class
            System.Console.WriteLine("Box is Created");
        }
        public void Open(){
            System.Console.WriteLine("Box is Opened");
        }
        public void Close(){
            System.Console.WriteLine("Box is Closed");
        }
        public override String ToString(){
            return $"Height : {height}, Length : {length}, Width : {width}";
        }
    } 
    internal class WoodenBox : Box{    //inheritence //If parent doesnt have parameterless constructer
        public int Area;
        public WoodenBox() : base(1){
            System.Console.WriteLine("Wooden Box Constructor");
        }
        public WoodenBox(int x) : base(x){
            System.Console.WriteLine("Wooden Box Constructor2");
        }
        public WoodenBox(int x, int y) : base(x){
            System.Console.WriteLine("Wooden Box Constructor3");
        }
        public void Open(){
            System.Console.WriteLine("Box is Opened in child");
        }
        public void Move(){
            System.Console.WriteLine("Wooden Box Shifted");
        }
        public override String ToString(){
            return "Hello";
        }
    }
    internal class BoxTester{
        public static void TestOne(){
            Box box = new Box(3);
            box.height = 100;
            box.width = 50;
            box.length = 200;
            box.Open();
            box.Close();
            String parameters = box.ToString();
            System.Console.WriteLine(parameters);
            /*box.Area = 300;
            box.Move();*/
        }
        public static void TestTwo(){
            WoodenBox box = new WoodenBox();
            WoodenBox box2 = new WoodenBox(3);
            WoodenBox box3 = new WoodenBox(3, 4);
            
            box.height = 100;
            box.width = 50;
            box.length = 200;
            box.Open();
            box.Close();
            String parameters = box.ToString();
            System.Console.WriteLine(parameters);
            
            box2.height = 100;
            box2.width = 50;
            box2.length = 200;
            box2.Open();
            box2.Close();
            String parameters2 = box2.ToString();
            System.Console.WriteLine(parameters2);
            
            box3.height = 100;
            box3.width = 50;
            box3.length = 200;
            box3.Open();
            box3.Close();
            String parameters3 = box3.ToString();
            System.Console.WriteLine(parameters3);

            box.Area = 300;
            box.Move();
        }
        public static void TestThree(){
            Box box = new WoodenBox(3);
            box.height = 100;
            box.width = 50;
            box.length = 200;
            box.Open();
            box.Close();
            String parameters = box.ToString();
            System.Console.WriteLine(parameters);
            /*box.Area = 300;
            box.Move();*/
        }
    }
}