using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_6
{
    public class Practice
    {
        public static void ArrayLists(){
            ArrayList list = new ArrayList();
            int i=1;
            while(i<10){
                list.Add("Hi");
                i++;
            }
            foreach(var j in list){
                System.Console.Write(j + " ");
            }
        }
        public static void Lists(){
            List<int> ls = new List<int>();
            String line = "1 2 3";
            var far = line.Split(" ");
            foreach (var j in far){
                ls.Add(int.Parse(j));
            }
            int[] arr = {7, 8, 9};
            ls.Insert(1, 4);
            ls.InsertRange(2,arr);
            foreach (var j in ls){
                System.Console.Write(j + " ");
            }
        }
    }
}