using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            b.StartEngine();
            b.FillGas(15);
            Console.WriteLine("Time is..." + b.Travel(100,50)+" hrs");
            Console.ReadKey();
        }
    }
}
