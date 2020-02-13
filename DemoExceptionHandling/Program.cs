using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n / 2);
                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[45]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " " + e.StackTrace + " " + e.Source);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace+" "+e.Source);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace + " " + e.Source);
            }
            
            Console.ReadKey();
        }
    }
}
