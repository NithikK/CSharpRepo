using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    public class StringStreamDemo
    {
        //converts a string to array of bytes,
        //byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
        //converts a array of bytes to string,
        //byte[] verifyArray = binReader.ReadBytes(arrayLength);
        //String stringOutput = Encoding.ASCII.GetString(verifyArray);
        
        //Using BinaryWriter to store String 
        static MemoryStream memoryStream = new MemoryStream();
        public static void WriteStringToMemoryStream()
        {
            Console.WriteLine("MemoryStream Length " + memoryStream.Length);
            Console.WriteLine("Enter a String ");
            String inputData = Console.ReadLine();
            if(inputData==null)
            {
                System.Console.WriteLine("INPUT IS EMPTY");
                return;
            }
            byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
            BinaryWriter binWriter = new BinaryWriter(memoryStream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray);
            Console.WriteLine("Write Completed " + memoryStream.Length);
        }
        //Using BinaryReader to read string from MemoryStream
        public static void ReadStringFromMemoryStream()
        {
            if (memoryStream.Length == 0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
            // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(memoryStream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)memoryStream.Length;
            // memoryStream.Length is Long but binReader.ReadBytes(int)
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            String stringOutput = Encoding.ASCII.GetString(verifyArray);
            Console.WriteLine(stringOutput);
        }

        public static void PeekAndReadCharacters()
        {
            string readerText = "Tom and Jerry is an American animated media franchise and series of comedy short films created in 1940 by William Hanna and Joseph Barbera.\n" +
                " Best known for its 161 theatrical short films by Metro-Goldwyn-Mayer, the series centers on the rivalry between the titular characters of a cat named Tom and a mouse named Jerry.\n " +
                "Many shorts also feature several recurring characters.";

        

            Console.WriteLine("Original text:\n\n{0}", readerText);
            Console.WriteLine("*****************************************");
            StringReader strReader = new StringReader(readerText);
            // Peek to see if the next character exists
            try
            {
                while (strReader.Peek() > -1)
                {
                // Read a line from the Stream and display it on the console
                    Console.WriteLine(strReader.ReadLine()+"--");
                }
                Console.WriteLine("Data Read Complete!");
            }
            finally
            {
                //Close the stringReader
                strReader.Close();
            }
        }

    }
}