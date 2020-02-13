using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Bike
    {
        string name;
        string color;
       
        public void StartEngine()
        {
            Console.WriteLine("Bike Started at  " + DateTime.Now.Hour);
        }
        public void FillGas(int lit)
        {
            Console.WriteLine("Bike Filled With "+lit+" liters");
        }
        public int Travel(int dist,int speed)
        {
            int time = (int)(dist / speed);
            Console.WriteLine("You will reach your destination in " + dist / speed+" hrs");
            return time;
        }
    }
}
