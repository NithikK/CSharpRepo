using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes() {
            //shift + alt + . multi select for find and replace

            byte b1 = 255; //0 - 255
            Console.WriteLine(b1);

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float f1 = 42.82F;
            Console.WriteLine(f1);

            long l1 = 999999887765443221L;
            Console.WriteLine(l1);

            double d1 = 123.13253749403634673219806D;
            Console.WriteLine(d1);

            decimal de1 = 123.13253749403634673219806M;
            Console.WriteLine(de1);

            char c1 = 'A';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);

            int y = 68;
            char ch1 = (char)y;
            Console.WriteLine(ch1);

            String s1 = "Hello";
            Console.WriteLine(s1);

            
        }
        public static void TestMethod()
        {//header of method //Can use internal for friend access  
         //method body
            Console.WriteLine("Test");
        }

    }
}

/*ValueTypeLesson.TestValueTypes();
ValueTypeLesson.TestMethod();*/
