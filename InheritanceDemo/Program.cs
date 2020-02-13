using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Parent p = new Parent();
            child Obj = new child();
            GrandChild g = new GrandChild();
            p.getValues(8, "AsP.Net");
            p.Display();
            Obj.getValues(7, "C#");
            Obj.Display();
            Obj.Caluculate(5);
            g.getValues(5, ".Net");
            g.Display();
            g.Multi(5);*/
            Vechile v = new Vechile();
            Car c = new Car();
            Bus b = new Bus();
            v.start();
            v.stop();
            b.run();
            c.Drive();
            c.run();
            Console.ReadKey();
        }
    }
}
