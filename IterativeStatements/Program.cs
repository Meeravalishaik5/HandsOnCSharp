using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int i = 0;
            while(i<=10)
            {
                Console.WriteLine("Hello...", name);
                i++;
            }
        }
        public static int Returnfactorial(int k)
        {
            int fact = 1;
            /*for(int i=1;i<=k;i++)
            {
                fact = fact * i;
            }*/
            int i = 1;
            for(; ; )
            {
                if (i<= k)
                 {
                    fact = fact * i;
                    i++;
                 }
                else
                {
                    break;
                }
            }
            return fact;

        }
        public static void DisplayEven(int n)
        {
            for(int j = 1; j <= n; j++)
            {
                if (j % 2 == 1)
                {
                    continue;
                }
                Console.Write(j + "\t");
            }
        }
        public static void checkvowel(char ch)
        {
            switch(ch)
            {
                case 'a': Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default :Console.WriteLine("invalid input");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character...");
            char ch=char.Parse(Console.ReadLine());
            checkvowel(ch);
            Greet("Virat");
            int j=Returnfactorial(4);
            DisplayEven(100);
            Console.WriteLine("FACTORIAL IS.." + j);
            Console.ReadKey();
        }
    }
}
