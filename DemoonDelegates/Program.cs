using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoonDelegates
{
    public delegate void deligatePointer();
    public delegate double calAreaPointer(double a);
    class Program
    {
       
        static void Main(string[] args)
        {
            Program p = new Program();
            //deligatePointer mydel = new deligatePointer(p.print);
            deligatePointer mydel = p.print;
            mydel += p.display;//To do multicast method calls.
            calAreaPointer cal = Caluculate.calArea;
            cal += Caluculate.caldist;
            double a1=cal(20);
            cal += Caluculate.caldist;
            double d = cal(20);
            Console.WriteLine("distance is..." + d);
            Console.WriteLine("area of a square is..."+a1);
            mydel();
            mydel -= p.print;
            mydel();
            Console.ReadKey();
            
        }
        public void print()
        {
            Console.WriteLine("Welcome to Delegate");
        }
        public void display()
        {
            Console.WriteLine("Welcome to multicast Delegate");
        }


    }
}
