using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_6
{
    public enum FuelType { Petrol, Diesel, Gas}
    public class Car
    {
        public int RegistrationNo;
        public FuelType EFuel;
        public int[] Wheels;
        private readonly Engine Eng;
        private readonly Model Mdl;
        public Car(){
            Mdl = new Model(this);
            Eng = new Engine(this);
        }
        public Model GetModel(){
            return Mdl;
        }
        public Engine GetEngine(){
            return Eng;
        }
        
        public class Model{
            internal Model(Car outerCar){
                if(outerCar == null){
                    throw new NullReferenceException("Model is NULL");
                }
            }
            public static String RE_Model(){
                return "CX9348";
            }
        }
        public class Engine{
            internal Engine(Car outerCar){
                if(outerCar == null){
                    throw new NullReferenceException("Engine is NULL");
                }
            }
            public static String RE_Engine(){
                return "Horse Power 3000";
            }
        }
        public String ToString(){
            Car c1 = new Car();
            String output = $"Details of the Car : \n" +
            $"RegistrationNo : {RegistrationNo}\n" +
            $"Model : {Model.RE_Model()}\n" +
            $"FuelType : {EFuel}\n" +
            //$"Wheels : {for(int i; i < 4; i++){{Wheels[i]}}}\n" +
            $"Engine : {Engine.RE_Engine()}\n";
            return output;
        }
        
    }
    class TestCar
    {
        public static void TestOne(){
            Car c1 = new Car();
            Car.Model Mdl = c1.GetModel();
            Car.Engine Eng = c1.GetEngine();
            c1.RegistrationNo = 123;
            c1.EFuel = FuelType.Petrol;
            for(int i = 0; i < 4; i++){
                c1.Wheels[i] = i+1;
            }
            String output = c1.ToString();
            System.Console.WriteLine(output);
        }
    }
}