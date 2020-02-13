using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 10.4;
            float f = 10.3f;
            char ch = 'a';
            object o = i;
            object o1 = d;
            object o2 = f;
            object o3 = ch;
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.4;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char ch1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
            s = i.ToString();
            s = d1.ToString();
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
