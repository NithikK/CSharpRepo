using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    public class StringLessons
    {
        //global variables can or cannot be initialized because constructors will take care of it
        public static void DemoA(){
            //two ways for initiating strings
            String firstString = "Hello"; 
            char[] data = {'H', 'e', 'l', 'l', 'o'};
            String secondString = new String(data);
            System.Console.WriteLine(firstString + " " + secondString);
            String thirdString=String.Empty; //Best way //Local variables must be initialized
            int x = 0;
        }
        public static void DemoB(){
            String s1 = "Tom and Jerry are good friends"; 
            System.Console.WriteLine("Length " + s1.Length);
            Char[] data = s1.ToCharArray();
            foreach(char c1 in data){
                System.Console.WriteLine(c1);
            }
        }
        public static void DemoC(){
            String s1 = "Tom and Jerry are good friends"; 
            String[] words = s1.Split(' ');
            System.Console.WriteLine("Word Count " + words.Count());
            foreach(var item in words){
                System.Console.WriteLine(item);
            }
        }
        public static void DemoD(){
            //creates newly
            String s1 = "Tom and Jerry are good friends"; 
            String sUpper = s1.ToUpper();
            String sLower = s1.ToLower();
            System.Console.WriteLine("String        : " + s1);
            System.Console.WriteLine("StringInUpper : " + sUpper);
            System.Console.WriteLine("StringInLower : " + sLower);
        }
        public static void DemoE(){
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void TestStringEquals(){
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";

            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true

            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // true
        }
        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length "+s1.Length);
            //from the 5th Index rest of String 
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            //from the 5th Index next 10 char
            String s3 = s1.Substring(5,10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
        public static void TestCompareTo()
        {
            String s1 = "September";
            String s3 = "November";
            int x = s1.CompareTo(s3);
            Console.WriteLine("September Compare November = " + x);
            x = s1.CompareTo("Saptember");
            Console.WriteLine("September Compare Saptember = " + x);
            x = s1.CompareTo("September");
            Console.WriteLine("September Compare September = " + x);
            x = s1.CompareTo("Setpember");
            Console.WriteLine("September Compare Setpember = " + x);

    

            bool flag = s1.Contains("ber");
            Console.WriteLine("Contains- ber " + flag);
            String s2 = s1.Insert(3, " 2017 ");
            Console.WriteLine("Insert " + s2);

    

            var reversdata = s1.Reverse();
            String s4 = new String(reversdata.ToArray());
            Console.WriteLine("Reverse " + s4);
            //String s5 = s4.Reverse(); //cannot do this since the funtion returns collections
        }
        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";

        
            //Bubble Sort
            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(  names[j + 1]) >0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }
        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }
        public static void AssignSameStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                //String s2 ="Hello"; // Longer time
                s1="Hello"; // shorter time
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        public static void ModifyStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                s1 += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        // manipulating string takes too many memory and time and kills application
        //solution StringBuiler in .Net and StringBuffer in Java

        public static void Firstmethod()
        {
            String s1 = String.Format("{0} ,{1} , {2}", "A", "B", "C");
            Console.WriteLine(s1);
            // Out of Index
            //String s2 = String.Format("{0} ,{1} , {3}", "A", "B", "C");
            //Console.WriteLine(s2);
            // In Valid Input Format
            //String s3 = String.Format("{A , B, C}");
            //Console.WriteLine(s3);
            String x = "Alex";
            String y = $" Hello {x}";
            String s4 = $"Value1:{x} , Value2:{y}";
            Console.WriteLine(s4);
        }
    }
}