using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class Account
    {
        int bal, acno;
        string name, at;
        char ty;
     /*   public int Bal 
        {
            get
            {
                return bal;
            }
            set
            {
                bal = value;
            }
        }
        public int Acno
        {
            get
            {
                return acno;
            }
            set
            {
                acno = value;
            }
        }
        public int Amt
        {
            get
            {
                return amt;
            }
            set
            {
                amt = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string At
        {
            get
            {
                return at;
            }
            set
            {
                at = value;
            }
        }
        public char Ty
        {
            get
            {
                return ty;
            }
            set
            {
                ty = value;
            }
        }*/
        public Account(int acno,string name,string at)
        {
            //this.Bal = bal;
            this.acno = acno;
            this.name = name;
            this.at = at;
            //this.Ty = ty;
            //this.Amt = amt;
        }
        public void Deposit(int amt)
        {
            bal = bal + amt;
           
            //Console.WriteLine(bal);
        }
        public void Withdraw(int amt)
        {
            bal = bal - amt;
            //Console.WriteLine(bal);
        }
        public void Display()
        {
            Console.WriteLine("Account No is..."+acno+"\nAccount holder name.."+name+"\nAccount Type..."+at+"\nMain balance..."+bal);
        }
    }
}
