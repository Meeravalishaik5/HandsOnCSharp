using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            d.DisplayDeliveryDetails("Akthar", "Sehwag");
            d.DisplayDeliveryDetails(6);
            Console.ReadKey();
        }
    }
}

