using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    internal class Pyramid_106847_Nithik
    {
        public static void pyramid() {
            int num;
            Console.WriteLine("Enter the Number : ");
            num = Convert.ToInt16(Console.ReadLine());
            int spaces = num - 1;
            int  stars= 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= stars; k++)
                {
                    Console.Write(k);
                }
                for (int l = stars - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                spaces--;
                stars = stars + 2;
            }
            Console.WriteLine();
        }
    }
        
}

