using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    public class StreamReadWrite
    {
        public static void StreamWriterDemo()
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileC.txt";
            string[] lines =
            {
                "Chennai is the capital city",
                "Madurai is the Temple city",
                "Salem is the steal city"
            };
            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
            System.Console.WriteLine("File Created");
        }
            public static void StreamReaderFromFileDemo()
            {
                StringBuilder line = new StringBuilder(250);
                String fName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileA.txt";
                //doesnt need to be released in finally closes on its own since we use using keyword
                using (StreamReader sr = new StreamReader(fName))
                {
                    line.Append(sr.ReadLine());
                    while (!sr.EndOfStream)
                    {
                        line.Append(sr.ReadLine());
                        line.Append(Environment.NewLine);
                    }
                    Console.WriteLine(line.ToString());
                }//closes sr here
                System.Console.WriteLine("Completed");
            }
    }
}