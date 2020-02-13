using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Singleton
    {
        static int count = 0;
        static Singleton Instance = null;
        public Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine("printing " + s);
        }
        public static Singleton GetInstance
        {
            get
            {//Instance is null memory will be alloted only for first object
                if (Instance == null) return new Singleton();
                else
                    return Instance;//existing Instance ref returned
            }
        }
    }
}
