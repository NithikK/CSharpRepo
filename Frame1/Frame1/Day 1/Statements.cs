using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    internal class Statements
    {
        public static void TestOne() {
            Console.WriteLine("Enter Your Age : ");
            String ageAsString = Console.ReadLine();
            if (!IsNumeric(ageAsString) || ageAsString.Length != 0 ) {
                return;
            }
            int age = int.Parse(ageAsString);
            
            if (age < 18 && age > 60) {
                Console.WriteLine("SORRY!!! You cant Drive.");
            }
            else {
                Console.WriteLine("Yes, You can Drive.");
            }
            static bool IsNumeric(String Value)
            {
                bool result = true;
                if (Value == null)
                {
                    Console.WriteLine("Invalid String!!! Value is Null.......");
                    result = false;
                }
                char[] data = Value.ToCharArray();
                int length = data.Length;
                for (int i = 0; i < length; i++)
                {
                    char c1 = data[i];
                    int ascii = (int)c1;
                    if (ascii < 48 || ascii > 57)
                    {
                        Console.WriteLine("Value is not a NUMBER!!!");
                        return false;
                    }
                }
                return result;
            }
        }
    }
}
