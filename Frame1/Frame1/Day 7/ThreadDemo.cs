using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_7
{
    public class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            System.Console.WriteLine("ThreadID = " + id);
            System.Console.WriteLine("IsAlive = " + t1.IsAlive);
            System.Console.WriteLine("Priority = " + t1.Priority);
            System.Console.WriteLine("ThreadState = " + t1.ThreadState);
            System.Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");//changing culture to french
            System.Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            System.Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("ta-IN");
            System.Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
        }
    }
}