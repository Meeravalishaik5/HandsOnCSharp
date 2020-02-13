using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchcaseStatement
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("...Menu...");
            Console.WriteLine("1.Even/Odd\n2.Natural NO's\n3.Multiplication table\n4.Exit");
            for(; ; )
            {
                Console.WriteLine("Please Enter your choice...");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1 : Even();
                        break;
                    case 2:
                        Naturalnos(100);
                        break;
                    case 3:
                        Multi();
                        break;
                    case 4:return;
                        break;
                    default: Console.WriteLine("Invalid Choice..");
                        break;

                }

            }
        }
        public static void Even()
        {
            Console.WriteLine("Please Enter no..");
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
        public static void Naturalnos(int k)
        {
            Console.WriteLine("Natural nos...");
            for(int j = 1; j <= k; j++)
            {
                Console.Write(j + "\t");
            }
        }
        public static void Multi()
        {
            Console.WriteLine("Enter table no..");
            int a = int.Parse(Console.ReadLine());
            for(int l=1;l<=10;l++)
            {
                Console.WriteLine(a + "*"+l +"="+ l * a);
            }
        }
   
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
