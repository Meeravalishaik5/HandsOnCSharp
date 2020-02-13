using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,small,max;
            int[] a = new int[100];
            Console.WriteLine("Enter The Numbers how many needed...");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Elements in an Array...");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Elements in an Array are...");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i]+"\t");
            }
            small=a[0];
            for (i = 0; i < n; i++)
            {
                if (small > a[i])
                {
                    small = a[i];
                }
            }
            Console.WriteLine("The Smallest Value is..."+small);
            max = a[0];
            for (i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("The higgest Value is..." + max);
            Console.ReadKey();
        }
    }
}
