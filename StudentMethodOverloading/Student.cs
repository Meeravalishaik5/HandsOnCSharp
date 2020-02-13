using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMethodOverloading
{
   abstract class Student
    {
        protected int id;
        protected string name;
        protected double examfee;
       
       public abstract void displayDetails();
       public abstract double Payfee(double fee);
    }
    class Hostler : Student
    {
        double hostelfee;
        public override  void  displayDetails()
        {

        }
        public override double Payfee(double fee)
        {

            return 0;
        }
    }
    class DayScholar : Student
    {
        double transportfee;
        public  override void displayDetails()
        {

        }
        public  override double Payfee(double fee)
        {
            return 0;
        }
    }


}
