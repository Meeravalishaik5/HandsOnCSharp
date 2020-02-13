using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Threadclass th1 = new Threadclass();
            Thread th = new Thread(th1.countEven);
            Thread th2 = new Thread(th1.countOdd);
           // th.Priority = ThreadPriority.Lowest;
            //th2.Priority = ThreadPriority.Highest;
            th.Start();
            th2.Start();
            Console.WriteLine("main ends");
            Console.ReadKey();

        }
    }
}
