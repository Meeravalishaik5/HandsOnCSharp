using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Parent
    {
        int a;
        string b;
        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public void getValues(int x,string y)
        {
            this.A = x;
            this.B = y;
        }
        public void Display() 
        {
            Console.WriteLine(this.A + "\t" + this.B);
        }
    }
    class child : Parent
    {
        int c;
        public void Caluculate(int num)
        {
            c = this.A + num;
            Console.WriteLine(c);
        }
    }
    class GrandChild:child 
    {
        int d;
        public void Multi(int n)
        {
            d = this.A * n;
            Console.WriteLine(d);
        }
    }

}
