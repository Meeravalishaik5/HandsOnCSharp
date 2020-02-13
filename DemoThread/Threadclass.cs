using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoThread
{
    class Threadclass
    { 
        public void countEven()
        {
            lock (this) {
                for (int i = 0; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                   // if (i == 50)
                     //   Thread.Sleep(30000);

                }
            }
        }
        public void countOdd()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
