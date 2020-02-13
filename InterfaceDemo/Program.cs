using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SBI s = new SBI("hyd", "Bhel", "Sweety");
            ICICI c = new ICICI("Chennai", "Perungudi", "Sree");
            s.DisplayDetails();
            s.getIntrest();
            s.getGIntrest();
            c.DisplayDetails();
            c.getIntrest();
            c.getGIntrest();
            Console.ReadKey();
        }
    }
}
