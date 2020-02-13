using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a = new int[3, 3];
            Console.WriteLine("Enter Marks...");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The Marks are...");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("a[" + i + "," + j + "] = " + a[i, j] + "\t");
                }
            }
            int high;
            high = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        high = a[i, j];
                    }
                    else
                    {
                        if (a[i, j] > high)
                        {
                            high = a[i, j];
                        }
                    }
                }
                Console.WriteLine("\nHighest for subject " + (i + 1) + " is..." + high);
            }
            Console.ReadKey();
        }
    }
}

