using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Frame1.Day_8
{
    [Serializable]// this or like normal Interface below commented
    public class Customer //:ISerializable
    {
        private readonly double Id;
        public string Title = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string MiddleName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public double CreditLimit { get; set; }
        public Customer(double v1){ Id = v1; }
        public double GetID(){ return Id; }
        public override string ToString()
        {
            return $"Details : {Id} {FirstName} {MiddleName} {LastName} {CreditLimit}";
        }
    }
    public class TestBinaryFormatter
    {
        public static void SerializeCustomer()
        {
            Customer obj = new Customer(1001);
            obj.FirstName = "Venkat";
            obj.LastName = "Krishnan";
            obj.MiddleName = "B";
            obj.CreditLimit = 200000;
            Console.WriteLine("Before serialization");
            obj.ToString();
            Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            //Opens a file and serializes the object into it in binary format.
            using (Stream stream = File.Open(@"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\Customer.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                #pragma warning disable SYSLIB0011 
                formatter.Serialize(stream, obj);
            }
            Console.WriteLine("Completed.....");
        }
        public static void DeSerializeCustomer()
        {
            using (Stream stream = File.Open(@"C:\Users\nithik.k\source\Traning Phase\Frame1\Frame1\Day 8\FileHandling\Customer.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Customer obj = null;
                formatter = new BinaryFormatter();
                obj = (Customer)formatter.Deserialize(stream);
                Console.WriteLine("After deserialization the object contains: ");
                Console.WriteLine(obj.ToString());
                Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            }
        }
        public static void TestA(){}
    }
}