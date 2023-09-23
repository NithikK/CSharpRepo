using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    public class StreamLesson
    {
        //Char Streams
        public static void TestOne()
        {
            char ch;
            System.Console.WriteLine("Press a key followed by ENTER : ");
            int x = Console.Read();
            ch = (char)x; //get a char
            System.Console.WriteLine("\n" + x + " Your key is : " + ch);
        }
        public static void TestTwo()
        {
            char ch =' ';
            System.Console.WriteLine("Press a key q to exit : ");
            while (ch != 'q'){
                ch = (char)Console.Read(); //get a char
                System.Console.WriteLine("Your key is : " + ch);
            }
        }
        public static void TestThree()
        {
            System.Console.Out.WriteLine("Enter a sentence : ");
            string? str = Console.ReadLine();
            System.Console.Out.WriteLine(" " + str);
        }
        public static void TestNullableTypes()
        {
            int? x = 0;//datatype? ? is nullable datatype
            x = null;
            if(x.HasValue){
                System.Console.WriteLine(x.Value);
            }
            else{
                System.Console.WriteLine(x.GetValueOrDefault());//default in this case 0
            }
        }
    }
}