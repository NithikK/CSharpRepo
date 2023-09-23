// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Frame1.Test1
// {
//     public class SirAnswers
//     {
//         // What are Value types? Declare a variable for each Value type, and print its Max Value.
//         /**
//         * Value types are predefined datatypes in C#
//         * Value types are loaded in the stack
//         * Value types need not be instantiated
//         * Value types have default value
//         * Value types can not be set to NULL
//         * Value types contain value in the memory allocated to them
//         * When a value type is assigned to another value type a copy of the value will be created
//         * Struct and Enums are Value types
//         */
//         public static void QuestionOne()
//         {
//             byte byteOne = 1;
//             sbyte sbyteOne = 1;
//             short shortOne = 1;
//             int intOne = 1;
//             long longOne = 1;
//             float floatOne = 1.543f;
//             double doubleOne = 2345.76534d;
//             decimal decimalOne = 627637263.36263726372M;
//             char charOne = 'A';
//             bool boolOne = true;
//             Console.WriteLine(byte.MaxValue);
//             Console.WriteLine(sbyte.MaxValue);
//             Console.WriteLine(short.MaxValue);
//             Console.WriteLine(int.MaxValue);
//             Console.WriteLine(long.MaxValue);
//             Console.WriteLine(float.MaxValue);
//             Console.WriteLine(double.MaxValue);
//             Console.WriteLine(decimal.MaxValue);
//         }
//         /***
//         * What are Global variables, and what are local variables? Give an example
//         * Variables Declared at the class level are global Variables.
//         * Global Variables can be accessed in all the methods of the class.
//         * Local Variables are declared with in a method.
//         * The scope of the local Variable is limited to the block in which it is declared
//         */
//         // Global Variable
//         int x = 0;
//         public void QuestionTwo()
//         {
//             // Local Variable
//             int y = 100;
//             Console.WriteLine($"Global Variable x={x}");
//             Console.WriteLine($"Local Variable y={y}");
//         }
//         // Write a function that can count the words in a string 
//         public static void QuestionThreeA()
//         {
//             String strFriends = "Tom and Jerry are good friends";
//             string[] words = strFriends.Split(" ");
//             int wordCount = words.Length;
//             Console.WriteLine($"Word Count {wordCount}");
//         }
//         //  Write a function that can reverse the string
//         public static void QuestionThreeB()
//         {
//             String strFriends = "Tom and Jerry are good friends";
//             Console.WriteLine(strFriends);
//             // first Method
//             char[] charData = strFriends.ToCharArray();
//             int len = charData.Length;
//             StringBuilder sb = new StringBuilder(len + 10);
//             for (int i = len - 1; i >= 0; i--)
//             {
//                 sb.Append(charData[i]);
//             }
//             Console.WriteLine(sb.ToString());
//             // Second Method
//             var strReverse = strFriends.Reverse();
//             foreach (var item in strReverse)
//             {
//                 Console.Write(item);
//             }
//         }
//         // Write a function that counts the no of characters in the string 
//         public static void QuestionThreeC()
//         {
//             String strFriends = "Tom and Jerry are good friends";
//             Console.WriteLine($"Char Count: {strFriends.Length} ");
//         }
//         // Change the string to Uppercase and print
//         public static void QuestionThreeD()
//         {
//             String strFriends = "Tom and Jerry are good friends";
//             string strInUpper = strFriends.ToUpper();
//             Console.WriteLine(strFriends);
//             Console.WriteLine(strInUpper);
//         }
//         //Print from 10th char to the 15th char
//         public static void QuestionThreeE()
//         {
//             String strFriends = "Tom and Jerry are good friends";
//             String strPart = strFriends.Substring(10, 5);
//             Console.WriteLine(strFriends);
//             Console.WriteLine(strPart);
//         }
//         // How will you check if the input name contains only alphabets,
//         // and the length of the name is not less than 8 characters?
//         public static void QuestionFour()
//         {
//             Console.WriteLine("Enter a NAME");
//             String name = $"{Console.ReadLine()}";
//             int len = name.Trim().Length;
//             if (len < 8)
//             {
//                 String errorMessage = "Name is Lessthan 8 Char. Try Again...";
//                 throw new Exception(errorMessage);
//             }
//             char[] nameCharArray = name.Trim().ToUpper().ToCharArray();
//             foreach (var item in nameCharArray)
//             {
//                 int asciiValue = item;
//                 if (asciiValue < 65 || asciiValue > 90)
//                 {
//                     String errorMessage = "Name Must contain ONLY Alphabets. Try Again...";
//                     throw new Exception(errorMessage);
//                 }
//             }
//             Console.WriteLine($"Correct Input {name}");
//         }
//         //What are the essential differences between C# consts, Static, and readonly fields? 
//         /**
//         * For Constant Fields a Value must be assigned on declaration
//         * Constant value can not be changed
//         * Static Value need not be assigned on declaration
//         * Static Value can be changed
//         * An Object for the class need not be created for Static, and Constants
//         * Static, and Constants can be accessed using [ClassName.FieldName]
//         * Constants, and Static Fields are loaded in the stack, and shared 
//         * 
//         * For readonly fields value can be assigned only through the constructor
//         * Readonly Field can be accessed only through a reference
//         * ReadOnly Fields can not be modified after a value is assigned
//         * Different instances of the class can have different value for Readonly field
//         * Readonly fields are not shared
//         */
//         #region QuestionSix
//         public const float Pi = 3.14f; // Const Value must be assigned on declaration
//         public static int Price; // Static Value need not be assigned on declaration
//         public readonly int Id;
//     
//         {
//             this.Id = id;// For readonly fields value can be assigned only through the constructor
//         }
//         public static void TestStaticConstantReadOnly()
//         {
//             Console.WriteLine($"Constant Value: {TestOneAnswers.Pi}");
//             // TestOneAnswers.pi = 5454f; Constant value can not be changed
//             Console.WriteLine($"Static Value: {TestOneAnswers.Price}");
//             TestOneAnswers.Price = 3000; // Static Value can be changed
//             Console.WriteLine($"Static Value: {TestOneAnswers.Price}");
//             // Readonly Field can be accessed only through a reference
//             //  Console.WriteLine($"ReadOnly Value: {TestOneAnswers.Id}");
//             TestOneAnswers testOneAnswers = new TestOneAnswers(10001);
//             Console.WriteLine($"ReadOnly Value: {testOneAnswers.Id}");
//             // testOneAnswers.Id = 200001; ReadOnly Fields can not be modified after assigning Value
//             TestOneAnswers testtwoAnswers = new TestOneAnswers(10002);
//             Console.WriteLine($"ReadOnly Value: {testtwoAnswers.Id}");
//             // Different instances of the class can have different value for Readonly field
//             // Readonly fields are not shared
//         }

//         #endregion QuestionSix
//         /***
//         * Write a C# method called Swap that takes two int numbers as parameters (x and y) and 
//         * swaps their values.Then, write some code that declares v1 and v2 as int, initializes their
//         * values, and then calls Swap, passing in v1 and v2 as arguments.
//         * After calling Swap, v1 should have v2’s original value, and 
//         * v2 should have v1’s original value.
//         * 
//         */
//         public static void QuestionSeven()
//         {
//             int v1 = 35;
//             int v2 = 55;
//             Console.WriteLine($"v1={v1}, v2={v2}");
//             Swap(ref v1, ref v2);
//             Console.WriteLine("After Swap");
//             Console.WriteLine($"v1={v1}, v2={v2}");
//         }
//         public static void Swap(ref int x, ref int y)
//         {
//             x = x + y;// 90
//             y = x - y; // 90-55=35
//             x = x - y; //90-35=55
//         }
//         /**
//         * Create two interfaces ServiceA, ServiceB. 
//         * The interface ServiceA has the following methods: void fly()
//         * The interface ServiceB has the following methods: void run (), void swim() .
//         * Implement both the interfaces in a single class. 
//         * Test the implementation by writing a Test Class.
//         */
//         public interface IServiceA
//         {
//             void Fly();
//         }
//         public interface IServiceB
//         {
//             void Run();
//             void Swim();
//         }
//         public class ABServices : IServiceA, IServiceB
//         {
//             public void Fly()
//             {
//                 Console.WriteLine("Fly");
//             }
//             public void Run()
//             {
//                 Console.WriteLine("Run");
//             }
//             public void Swim()
//             {
//                 Console.WriteLine("Swim");
//             }
//         }
//         public static void QuestionEight()
//         {
//             IServiceA serviceA = new ABServices();
//             serviceA.Fly();
//             IServiceB serviceB = new ABServices();
//             serviceB.Swim();
//             serviceB.Run();
//         }
//         /***
//         * Find the error in the following code. 
//         * Fix the error and write a child class for the Box class
//         * public class Box{ public abstract void show();}
//         * Answer:
//         *       A class with abstract method must be declared as abstract
//         */
//         public abstract class Box
//         {
//             public Box()
//             {
//                 Console.WriteLine("Box Constructor");
//             }
//             public abstract void Show();
//         }
//         public class WoodenBox : Box
//         {
//             public WoodenBox()
//             {
//                 Console.WriteLine("WoodenBox constructor");
//             }
//             public override void Show()
//             {
//                 Console.WriteLine("WoodenBox.Show");
//             }
//         }
//         public static void QuestionNine()
//         {
//             Box box = new WoodenBox();
//             box.Show();
//         }
//         // Study the below code, and give the Exception path:
//         // ex8=>ex4=>ex1=>ex0=>bla bla
//     }
// }