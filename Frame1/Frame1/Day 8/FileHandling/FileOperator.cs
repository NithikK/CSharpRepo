using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    public class FileOperator
    {
        public static void TestOne(){
            String fName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileA.txt";
            string[] lines = {
                "Chennai is the Capital City.",
                "Madurai is the Temple City.",
                "Salem is the Steal City."
            };
            try{
                File.WriteAllLines(fName, lines);
                System.Console.WriteLine("File Created");
            }
            catch (Exception err){
                System.Console.WriteLine($"Error!!! {err.Message}");
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileA.txt";
            String newfName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }

            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory();//Directory.CurrentDirectory(path) can also be used
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }

        

        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static void FileWriteAllText()
        {
            String fNameb = @"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\myfileB.txt";
            string[] lines =
            {
                "Chennai is the capital city",
                "Madurai is the Temple city",
                "Salem is the steal city"
            };
            StringBuilder sb = new StringBuilder(100);
            sb.Append(lines[0]);
            sb.Append(Environment.NewLine); // sb.Append("\\n");
            sb.Append(lines[1]);
            sb.Append(Environment.NewLine);
            sb.Append(lines[2]);
            sb.Append(Environment.NewLine);
            File.WriteAllText(fNameb, sb.ToString());
            System.Console.WriteLine("File Created");
        }
        
    }
}