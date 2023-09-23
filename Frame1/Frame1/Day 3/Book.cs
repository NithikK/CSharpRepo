using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    //if there are abstract methods in a class then the class should be named with abstract keyword
    //abstract methods are mainly for interfaces so abstract class is not used usually
    public abstract class Book
    {
        public Book (){
            System.Console.WriteLine("Book Constructor");
        }
        public abstract void OpenBook(); //abstract methods must be overridden
    }
    internal class EBook : Book{
        public EBook (){
            System.Console.WriteLine("EBook Constructor");
        }
        public override void OpenBook(){
            System.Console.WriteLine("EBook Open");
        }
    }
    class BookTester{
        public static void TestOne(){
            Book book = new EBook();
            book.OpenBook();
        }
    }
}