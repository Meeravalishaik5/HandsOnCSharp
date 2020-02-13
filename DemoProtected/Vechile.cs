using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProtected
{
    class Vechile
    {
        string color;
        public Vechile()
        {
            this.color = "green";
            Console.WriteLine("Constructor from Vechile...");
        }
        public void start()
        {
            Console.WriteLine("Vechile started...");
        }
        public void stop()
        {
            Console.WriteLine("Vechile stopped...");
        }
    }
    class Bus : Vechile
    {
        int seating;
        int speed;
        public Bus()
        {
            this.seating = 60;
            this.speed = 140;
            Console.WriteLine("Constructor from Bus...");
        }
        public void run()
        {
            Console.WriteLine("bus is Running...");
        }
    }
    class Car : Vechile
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 120;
            this.type = "standard";
            Console.WriteLine("Constuctor from Car...");
        }
        public void Drive()
        {
            Console.WriteLine("started...");
        }
    }
}
