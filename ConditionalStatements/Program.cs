    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "EVEN";
            }
            else
            {
                return "ODD";

            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if(i>k)
                {
                    return i;
                }
                else
                {
                    return k;
                }
            }
            else
            {
                if (j > k)
                {
                    return j;
                }
                else
                {
                    return k;
                }
            }
        }
        public static string ResultOf(int i,int j,int k,int l,int n)
        {
            double avg = i + j + k + l + n / 5;
            if (avg >= 70)
            {
                return "Distinction";
            }
            else if(avg>=60 && avg<70)
            {
                return "First class";
            }
            else if(avg >= 50 && avg < 60)
            {
                return "Second Class";
            }
            else
            {
                return "FAIL";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY NO : ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ANY NO : ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ANY NO : ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ANY NO : ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ANY NO : ");
            int n = int.Parse(Console.ReadLine());
            string c = ResultOf(i, j, k, l, n);
            Console.WriteLine(c);
            string j1 = EvenorOdd(i);
            int m = Max(i, j, k);
            Console.WriteLine("Max is :{0}", m);
            Console.WriteLine(j1);
            Console.ReadKey();

        }
    }
}
