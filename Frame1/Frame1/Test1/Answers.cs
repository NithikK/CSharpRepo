// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Cryptography.X509Certificates;
// using System.Threading.Tasks;

// namespace Frame1.Test1
// {
//     public class Answers
//     {
//         public static void Question1(){
//             byte b = 0;
//             sbyte sb = 0;
//             short sh = 12;
//             bool flag = false;
//             int num = 1234;
//             char ch = 'A';
//             long l = 123456789L;
//             float f = 10.32F;
//             double d = 100.3456D;
//             decimal de = 10.34M;
//             System.Console.WriteLine(byte.MaxValue);
//             System.Console.WriteLine(sbyte.MaxValue);
//             System.Console.WriteLine(short.MaxValue);
//             System.Console.WriteLine(int.MaxValue);
//             System.Console.WriteLine(long.MaxValue);
//             System.Console.WriteLine(float.MaxValue);
//             System.Console.WriteLine(double.MaxValue);
//             System.Console.WriteLine(decimal.MaxValue);
//         }
//         public class Question2{
//             public class DemoA{
//                 public int x = 20;//Global Variable
//                 public static void Test(){
//                     System.Console.WriteLine(" X = " + x);
//                     int x=10;//Local Variable
//                     System.Console.WriteLine(" X = " + x);
//                 }
//             }
//         }
//         public class Question3{
//             String strFriends = "Tom and Jerry are good friends";
//             public static void TestA(String str){
//                 var far = str.Split(" ");
//                 String[] array = new String(far.ToArray()); 
//                 System.Console.WriteLine();
//             }
//             public static void TestB(){}
//             public static void TestC(){}
//             public static void TestD(){}
//             public static void TestE(){}

//         }
//         public static void Question4(){   
            
//         }
//         public class Question9{   
//             public abstract class Box{
//                 public abstract void show();
//             }
//             public class WoodenBox : Box{
//                 public override void show(){

//                 }
//             }
//         }
//         public static void Question10() {
//             try // try1
//             {
//                 try // try2
//                 {
//                     try //try3
//                     {
//                         try //try4
//                         {
//                             throw new Exception("bla bla");
//                         }
//                         catch (Exception ex0)
//                         {
//                             throw new ApplicationException("ex0"+ex0.Message);
//                         }//end of try4
//                     }
//                     catch (ApplicationException ex1)
//                     {
//                         throw new IndexOutOfRangeException("ex1"+ex1.Message);
//                     }
//                     catch (Exception ex2)
//                     {
//                         throw new Exception("ex2"+ex2.Message);
//                     }//end of try3
//                 }
//                 catch (ApplicationException ex3)
//                 {
//                     throw new DllNotFoundException("ex3"+ex3.Message);
//                 }
//                 catch (IndexOutOfRangeException ex4)
//                 {
//                     throw new ArgumentNullException("ex4"+ex4.Message);
//                 }
//                 catch (Exception ex5)
//                 {
//                     throw new Exception("ex5"+ex5.Message);
//                 }// end of try2
//             }
//             catch (ApplicationException ex6)
//             {
//                 throw new ArgumentNullException("ex6"+ex6.Message);
//             }
//             catch (DllNotFoundException ex7)
//             {
//                 throw new DllNotFoundException("ex7"+ex7.Message);
//             }
//             catch (ArgumentNullException ex8)
//             {
//                 throw new ArgumentNullException("ex8"+ex8.Message);
//             }
//             catch (Exception ex9)
//             {
//                 throw new ArgumentNullException("ex9"+ex9.Message);
//             }// end of try1
//         }
//     }
// }