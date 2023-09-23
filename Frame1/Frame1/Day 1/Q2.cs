using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_1
{
    public class Q2
    {
        public static void Num(){
            for(int i=1; i<= 100; i++){
	            if(i%3==0 && i%5!=0){
		            Console.WriteLine("Apple");
                }
                else if(i%5==0 && i%3!=0){
		            Console.WriteLine("Orange");
                }
                if(i%3==0 && i%5==0){
		            Console.WriteLine("Grapes");
                }
                Console.WriteLine(i);
            }
        }
    }
}