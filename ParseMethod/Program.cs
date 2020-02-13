using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte i1 = sbyte.Parse("123");
            float f1 = float.Parse("123.23");
            decimal d1 = decimal.Parse("123.45");
            Console.WriteLine("{0} {1} {2}", i1, f1, d1);
            Console.ReadKey();
            /*string s = "100";
                        int i = int.Parse(s);
                        double d = double.Parse(s);
                        long l = long.Parse(s);*/

        }
    }
}
