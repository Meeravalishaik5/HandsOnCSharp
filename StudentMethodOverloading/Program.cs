using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s=new Hostler();
            s.displayDetails();
            s.Payfee(34.45);
            s= new DayScholar();
            s.displayDetails();
            s.Payfee(67.67);
        }
    }
}
