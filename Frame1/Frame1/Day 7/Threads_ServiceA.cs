using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_7
{
    public class Threads_ServiceA
    {
        int x = 0;//shared between both threads since global //global variables are not thread safe//overwrites since two or more threads access simultaniously
        public void DoTaskA(){
            //Thread Locks
            //Always release locks/ costly resource inside finally
            //A terminated or stopped thread cannot be restarted
            //Fork is a point where a single thread becomes multiple threads
            //see pic
          
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            System.Console.WriteLine("Inside DoTaskA");
            System.Console.WriteLine("\t Thread ID : " + id);
            //int x = 0;
              try{
                    for(int icount = 0; icount <= 5; icount++){
                        x += icount;
                        System.Console.WriteLine("\tID = " + id + " : X = " + x + " icount = " + icount);
                        Thread.Sleep(1000);
                    }
                }
                finally{
                    Monitor.Exit(t1);
                }
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("MainTh ID " + id);
            Threads_ServiceA a1 = new Threads_ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            //Local variables are thread safe by default on their own doesnt overwrite
            //Each thread will get the copy of its own variable
            //A thread cannot access code in another stack
            //Two or more threads that come to gether is a join
            //Os creates and owns threads 
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("MainTh ID " + id);
            Threads_ServiceA a1 = new Threads_ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            t1.Start();
            a1.DoTaskA();
            System.Console.WriteLine("--------------------End of DemoB----------------------------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("MainTh ID " + id);
            Threads_ServiceA a1 = new Threads_ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            System.Console.WriteLine(t1.ManagedThreadId + " T1 State " + t1.ThreadState);
            t1.Start();
            System.Console.WriteLine(t1.ManagedThreadId + " State After Start " + t1.ThreadState);
            Thread.Sleep(6000);
            System.Console.WriteLine(t1.ManagedThreadId + " T1 State After Sleep " + t1.ThreadState);
            System.Console.WriteLine("--------------------End of DemoB----------------------------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            System.Console.WriteLine("MainTh ID " + id);
            Threads_ServiceA a1 = new Threads_ServiceA();
            ThreadStart ts = a1.DoTaskA;//delegate
            //forking
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            //join
            t1.Join(7000);
            //if(t1.IsAlive) t1.Abort();
            t2.Join(7000);
            //if(t2.IsAlive) t2.Abort();
            Console.WriteLine("--------------------End of DemoC----------------------------");
            //Abort is illegal now after 2022 patch
        }
    }
}