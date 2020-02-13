using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesWithDatatypes
{
    class Program
    {
        string name;
        static double salary;
        static void Main(string[] args)
        {
            long l2 = 12500;
            int i2 = (int)12;
            int i = 256;
            byte b1 = (byte)i;
            float f = 12.2f;
            int i3 = (int)f;
            float b2 = 1f;
            float b3 = b1 + b2;
            Console.WriteLine(b3);
            long b4 = 1;
            double b5 = 2;
            double b6 = b4 + b5;
            int a3 = (int)b6;
            Console.ReadKey();

        }
    }
}
