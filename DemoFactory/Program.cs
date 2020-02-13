using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    interface Ifactory 
    {
        void manufacture(int cnt);
    }
    class Bike : Ifactory 
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Bike Manufacturing NO: "+cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Car Manufacturing NO: " + cnt);
        }
    }
    abstract class VechileFactory 
    {
        public abstract Ifactory generateVechiles(string type);
    }
    class ConcreteVechile:VechileFactory
    {
        public override Ifactory generateVechiles(string type)
        {
                if(type=="Bike") 
                    return new Bike();
                else  
                   return new Car();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VechileFactory obj = new ConcreteVechile();
            Ifactory myvech=obj.generateVechiles("Bike");
            myvech.manufacture(10);
            myvech = obj.generateVechiles("Car");
            myvech.manufacture(20);
            Console.ReadKey();
        }
    }
}
