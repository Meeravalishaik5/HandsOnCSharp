using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int w)
        {
            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l,int w,int b)
        {
            Console.WriteLine("A box can be drawn");
        }
        public void draw(int l,int w,int b,string name)
        {
            Console.WriteLine(name+" shape can be drawn");
        }
    }
}
