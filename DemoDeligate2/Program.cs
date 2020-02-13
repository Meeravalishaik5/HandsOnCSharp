using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate2
{
   // public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //calAreaPointer cptr = new calAreaPointer(delegate(double r) { return 3.14 * r * r; });
            //double area = cptr(12);//Anonymous method reference...
            //calAreaPointer cptr1 = (r => 3.14 * r * r);
            //double area1 = cptr1(10);
           // Console.WriteLine(area+" "+area1);
            //prebuild delegates Func<>,Action<>,Predicate<>
            //Func<> delegate can have i/p and o/p parameter
            Func<double, double> f1 = r => 3.14 * r * r;
            double area2 = f1(4);
            Console.WriteLine(area2);
            Action<string> act = (k => Console.WriteLine(k));
            act("Welcome");
            Predicate<string> p = (y => y.Length > 3);
            Console.WriteLine(p("cts"));
            int[] array = new int[] { 1, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("ajay");
            names.Add("ravi");
            names.Add("maya");
            int x = array.Count(x1 => x1 > 3);
            List<string> sn = names.FindAll(z => z.Contains("y"));
            Console.WriteLine(x);
            foreach(string b in sn)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
