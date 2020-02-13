using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParams
{
    class Caluculator
    {
        public void Add(params int[] a)
        {
            int res = 0;
            foreach(int i in a)
            {
                res += i;
            }
            Console.WriteLine(res);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Caluculator c = new Caluculator();
            c.Add(10, 23, 14, 24, 75, 34);
            Console.ReadKey();
        }
    }
}
