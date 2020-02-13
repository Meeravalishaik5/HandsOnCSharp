using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Caluculator cal = new Caluculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            cal.Add(x,y);
            cal.Subtract(x, y, out int sub);
            Console.WriteLine(sub);
            cal.Swap(ref x,ref y);
            Console.ReadKey();
        }
    }
}
