using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account no...");
            int acno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account Type...");
            string At = Console.ReadLine();
            Account ac1 = new Account(acno,name,At);
            int bal = 0;
            Console.WriteLine("1.Press d to Deposit\n2.press w to Withdraw\n3.Prees e to exit..");
            for (; ; )
            {
                Console.WriteLine("enter Transaction type...");
                char ch = char.Parse(Console.ReadLine());
                int amt;
                switch (ch)
                {
                    case 'd':
                        Console.WriteLine("Enter Amount...");
                        amt = int.Parse(Console.ReadLine());
                         ac1.Deposit(amt);
                               ac1.Display();
                               break;
                    case 'w':
                               Console.WriteLine("Enter Amount...");
                               amt = int.Parse(Console.ReadLine());
                               ac1.Withdraw(amt);
                               ac1.Display();
                               break;
                    case 'e': return;
                    default : Console.WriteLine("Invalid Transaction type...");
                        break; 

                }
            }
            Console.ReadKey();
        }
    }
}

