using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape obj = new Shape();
            obj.draw();
            obj.draw(5);
            obj.draw(5,6);
            obj.draw(5,6,8);
            obj.draw(5, 6, 8,"Any ");
            Console.ReadKey();
        }
    }
}
