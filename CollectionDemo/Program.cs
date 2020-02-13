using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any Odd length of size...");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Please Enter an Odd Length of size..");
            }
            else
            {
                int[] a = new int[n];
                Console.WriteLine("Enter array elemets..");
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The array elemets are..");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + "\t");
                }
                Console.WriteLine();
                int start = a[0];
                int end = a[n-1];
                int middle = a[n/2];
                if (start > end && start>middle)
                {
                    Console.WriteLine("largest is.." + start);
                }
                else if(end>start && end > middle)
                {
                    Console.WriteLine("largest is.." + end);
                }
                else
                {
                    Console.WriteLine("largest is.." + middle);
                }
            }
            Console.ReadKey();
        }
    }
}
