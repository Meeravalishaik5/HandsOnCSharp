using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Delivery
    {
        public void DisplayDeliveryDetails(String Bowl,String Bat)
        {
            Console.WriteLine("Bowler is.." + Bowl+"\nBatsmen.."+Bat);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
            {
                Console.WriteLine("It is a six.."+runs);
            }
            else if (runs == 4)
            {
                Console.WriteLine("It is a four.." + runs);
            }
            else
            {
                Console.WriteLine(runs);
            }
        }
    }
}
