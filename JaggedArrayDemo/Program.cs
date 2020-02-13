using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] n = new int[2][];
            int r, c;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Size...");
                int size = int.Parse(Console.ReadLine());
                n[i] = new int[size];
            }
            Console.WriteLine("Enter elements...");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < n[r].Length; c++)
                {
                    n[r][c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The rows are...");
            for (r = 0; r < 2; r++)
            {
                Console.WriteLine("\nThe Row " + (r + 1) + " is...");
                for (c = 0; c < n[r].Length; c++)
                {
                    Console.WriteLine(" " + n[r][c]);

                }
                Console.WriteLine();
            }
            int sum = 0;
            for(r=0;r<2;r++)
            {
                   if(r == 0)
                    {
                           if (n[r][c] == n[r][c + 1])
                            {
                                sum = n[r][c] + n[r][c + 1];
                                Console.WriteLine(sum);
                            }
                            n[r][c] = n[r][c + 1];
                    }
                    if(r==1)
                    {
                        for (c = 0; c < n[r].Length-1; c++)
                        {
                            if (n[r][c] == n[r][c + 1])
                            {
                                sum = n[r][c] + n[r][c + 1];
                                Console.WriteLine(sum);
                            }
                            else
                            {
                                n[r][c] = n[r][c + 1];
                            }
                    }
                    }
                
            }
            Console.ReadKey();
        }
    }
}



