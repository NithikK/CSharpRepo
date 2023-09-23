using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_5
{
    public class Reference
    {
        public static void DoTask(int x){
            int i = x + 2000;
            x = i;
            System.Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x){
            int i = x + 2000;
            x = i;
            System.Console.WriteLine(x);
        }
    }
    public class ReferenceTester{
        public static void TestOne(){
            int v1 = 1000;
            System.Console.WriteLine($"V1 : {v1}");
            Reference.DoTask(v1);
            System.Console.WriteLine($"V1 : {v1}");
            Reference.DoTaskA(ref v1);
            System.Console.WriteLine($"V1 : {v1}");
        }
    }
}