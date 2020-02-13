using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemoOfGrade
{
    abstract class Student
    {
        string name;
        int studentid;
        double grade;
       /* public Student(string n,int id,double grade)
        {
            this.name = n;
            this.studentid = id;
            this.grade = grade;
        }*/
       public abstract Boolean IsPassed(double g); 
    }
    class Undergraduate : Student
    {
        public override Boolean IsPassed(double g)
        {
            if (g > 70.0)
                return true;
            else
                return false;
        }
    }
    class Graduate : Student
    {
        public override Boolean IsPassed(double g1)
        {
            if (g1 > 80.0)
                return true;
            else
               return false;
        }
    }
}
