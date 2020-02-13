using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] a = new int[5] { 10, 4, 6, 78, 5 };
            int sum = 0;
            double[] d = new double[3] { 12.2, 35.5, 7.7 };
            char[] ch = { 'a', 's', 'g' };
            object[] ob = new object[3] { "RT", 23, true };*/
            string[] n =  new string[4]{ "hari", "suma","allah","siddu" };
            Console.WriteLine("Enter name to Search...");
            string k = Console.ReadLine();
            int i,m=0;
            for(i=0;i<n.Length;i++)
            {
                if (k.Equals(n[i]))
                {
                    m = 1;
                }

            }
            if (m == 1)
            {
                Console.WriteLine("Found...");
            }
            else
            {
                Console.WriteLine("Not Found...");
            }
            Console.ReadKey();

        }
    }
}
