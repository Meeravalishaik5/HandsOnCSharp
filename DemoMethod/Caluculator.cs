using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Caluculator
    {
        int val1;
        int val2;
        public int va1
        {
            get
            {
                return val1;
            }
            set
            {
                val1 = value;
            }
        }
        public int va2
        {
            get
            {
                return val2;
            }
            set
            {
                val2 = value;
            }
        }
        public Caluculator()
        {
            this.va1 = val1;
            this.va2 = val2;
        }
        public void Add(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public void Subtract(int n1, int n2,out int s)
        {
            s = n1 - n2;
        }
        /*public void Swap(int num1,int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1+" "+num2);
        }*/
        public void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1 + " " + num2);
        }

    }
}
