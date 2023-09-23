using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Private Constructors example
namespace Frame1.Day_2
{
    internal class Movie
    {
        private Movie(){
            System.Console.WriteLine("");
        }
        public static Movie CreateMovie(){
            return new Movie();
        }
    }
    internal class MovieTester
    {
        public static void TestOne(){
            Movie movie = Movie.CreateMovie(); 
        }
    }
}