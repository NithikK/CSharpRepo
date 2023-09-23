using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_7
{
    public class LambdaDemo
    {
        static void DemoA()
        {
            Func<int, int> f1 = x => x / 2; //first int is parameter and second is result 
            //Last int is always the result
            /* The above short form is Lambda Expressions
            public int f1(int x){
                return x/2;
            }
            */
            int i = 100;
            int result = f1(i);
            System.Console.WriteLine(result);
        }
        static void DemoB()
        {
            Func<int> f2 = () => 100;//Has Reurnt type but no parameter
            int result = f2();
            System.Console.WriteLine(result);
        }
        static void DemoC()
        {
            Func<double, double, double> f3 = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = f3(v1, v2);
            System.Console.WriteLine(result);
        }
        static void DemoD()
        {//UpCasting no problem int -> double
            Func<int, double> f4 = x => (double) x / 2;//int ah divide panna int than varum so enga podurom
            int v1 = 101;
            double result = f4(v1);
            System.Console.WriteLine(result);
        }
        static void DemoE()
        {//DownCasting needs to be mentioned double -> int
            /*ERROR
            Func<double, int> f5 = x => x / 2;
            int v1 = 101;
            double result = f5(v1);
            System.Console.WriteLine(result);
            */
        }
        static void DemoF()
        {//to solve DemoE
            Func<double, int> f4 = x => (int) x / 2;
            int v1 = 101;
            double result = f4(v1);
            System.Console.WriteLine(result);
        }
        static void Echo(Func<string> f5){
            string str = f5();
            System.Console.WriteLine(str);
        }
        static void TestEcho(){
            Echo(() => "Hello");
            Echo(() => "World");
        }
        static double Dotrans(Func<int, int, double> f6){
            return f6(50, 5);
        }
        static void TestDotrans(){
            Func<int, int, double> Multiply = (x, y) => x * y;
            double d = Dotrans(Multiply);
            System.Console.WriteLine(d);
            Func<int, int, double> Add = (x, y) => x + y;
            d = Dotrans(Add);
            System.Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) => {
                if (y == 0) y = 1; return x / y;
            };
            d = Dotrans(Divide);
            System.Console.WriteLine(d);
        }
        public static double Run(int v1, int v2)
        {
            if(v2 == 0) return 0;
            return v1 / v2;
        }
    }
}