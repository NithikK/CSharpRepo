using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_3
{
    //by default public
    //no constructors or concrete methods
    //by default abstract methods
    //inherit abstract class but u impliment interface
    //cannot create objects
    //interfaces must be implemented
    //a class that implements interface must implement all methods and if any method not implemented then class should be named abstract
    //a class can implement more than one interface
    //multiple inheritence is not supported that is from multiple parents but can implement multiple interfaces
    //for code reuse dont inherit (usual practice but its allowed)
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    public interface IPayments{
        void Makepayment(float amount);
    }
    internal class Whatsapp : IMessageService, IPayments
    {
        public void DeleteMessage(){
            System.Console.WriteLine("Method Not Implemented");;
        }
        public void ReceiveMessage(){
            System.Console.WriteLine("Method Not Implemented");;
        }
        public void SendMessage(string message){
            System.Console.WriteLine("Method Not Implemented");;
        }
        public void SendAudioMessage(string message){
            System.Console.WriteLine("Method Not Implemented");;
        }
        public void SendVideoMessage(string message){
            System.Console.WriteLine("Method Not Implemented");;
        }
        public void Makepayment(float amount){
            System.Console.WriteLine($"Paid Amount : {amount}");;
        }
        
    }
    public class MessageTester{
        public static void TestOne(){
            IMessageService messageService = new Whatsapp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMessage();
        }
        
    }
}