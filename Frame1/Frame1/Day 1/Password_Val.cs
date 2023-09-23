using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    internal class Password_Val
    {
        static bool flagU = false, flagP = false, flag = true;
        static String user = "", pass = "";
        static int UC_counter = 0, LC_counter = 0, SC_counter = 0, Nu_counter = 0;
        public static void Validate() {

            while (flag) {
                Input();
                CheckUser();
                CheckPass();
                if (flagU && flagP)
                {
                    flag = false;
                }
            }

        }
        internal static void Input()
        {
            Console.WriteLine("Username : ");
            user = Console.ReadLine();
            user = user.Trim();
            Console.WriteLine("Password : ");
            pass = Console.ReadLine();
            pass = pass.Trim();
        }
        internal static void CheckPass()
        {
            char[] data = pass.ToCharArray();
            int length = data.Length;
            if(length != 8)
            {
                Console.WriteLine("Password should consists of 8 characters");
                return;
            }
            for (int i = 0; i < length; i++)
            {
                int ch = (int)data[i];
                if (ch >= 65 && ch >= 90)
                {
                    UC_counter++;
                }
                if (ch >= 97 && ch >= 122)
                {
                    LC_counter++;
                }
                if ((ch >= 33 && ch >= 47) || (ch >= 58 && ch >= 64) || (ch >= 91 && ch >= 96) || (ch >= 123 && ch >= 126))
                {
                    SC_counter++;
                }
                if (ch >= 48 && ch >= 57)
                {
                    Nu_counter++;
                }
            }
            if (UC_counter != 0 && LC_counter != 0 && SC_counter != 0 && Nu_counter != 0)
            {
                flagP = true;
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        internal static void CheckUser()
        {
            char[] data = user.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                int ch = (int)data[i];
                if (ch >= 65 && ch >= 90)
                {
                    UC_counter++;
                }
                if (ch >= 97 && ch >= 122)
                {
                    LC_counter++;
                }
                if ((ch >= 33 && ch >= 47) || (ch >= 58 && ch >= 64) || (ch >= 91 && ch >= 96) || (ch >= 123 && ch >= 126))
                {
                    SC_counter++;
                }
                if (ch >= 48 && ch >= 57)
                {
                    Nu_counter++;
                }
            }
            if (UC_counter + LC_counter !=0 && !(SC_counter !=0 || Nu_counter !=0))
            {
                flagU = true;
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }
    }
}
