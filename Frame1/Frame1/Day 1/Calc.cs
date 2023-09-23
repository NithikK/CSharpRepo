using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    internal class Calc
    {
        internal static double Add(double x, double y) {
            return x + y;
        }
        internal static double Divide(double x, double y) {
            if (y == 0) {
                return -1;
            }
            return x / y;
        }
        internal static double Multiply(double x, double y) {
            return x * y;
        }
        internal static double Subtract(double x, double y) {
            return x - y;
        }
        internal static double Power(double x, double y) {
            return Math.Pow(x,y);
        }

    }
}





/* main  code
double n1, n2;
int opt;
Console.WriteLine("--------------------");
Console.WriteLine("     Calculator     ");
Console.WriteLine("--------------------");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Divide");
Console.WriteLine("5 - Power");
opt = Convert.ToInt16(Console.ReadLine()); //int.Parse can also be used
Console.WriteLine("Enter the First Number : ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the Second Number : ");
n2 = Convert.ToDouble(Console.ReadLine());
switch (opt) { 
    case 1: { Console.WriteLine(Calc.Add(n1, n2)); break; }
    case 2: { Console.WriteLine(Calc.Subtract(n1, n2)); break; }
    case 3: { Console.WriteLine(Calc.Multiply(n1, n2)); break; }
    case 4: {
            if (Calc.Divide(n1, n2) != -1) { Console.WriteLine(Calc.Divide(n1, n2)); }
            else { Console.WriteLine("Not Defined"); }
            Console.WriteLine(); break; }
    case 5: { Console.WriteLine(Calc.Power(n1, n2)); break; }
}
*/