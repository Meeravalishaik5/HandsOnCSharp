using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Student
    {
        private int rollno, marks;
         public int Sem { get; set; }//Auto implemented
        private string name, branch;
        public int Rollno 
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Branch
        {
            get
            {
                return branch;
            }
            set
            {
                branch = value;
            }
        }
       /* public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }*/
        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
        public Student(string n,int r,string b,int s,int m)
        {
            this.name =n;
            this.rollno = r;
            this.branch = b;
            this.Sem = s;
            this.marks = m;
        }
        public void AcceptStudentDetails()
        {
            Console.WriteLine("Student Details are accepted....");
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Rollno.." + this.Rollno);
            Console.WriteLine("Name.." +this.Name);
            Console.WriteLine("Semester.." + this.Sem);
            Console.WriteLine("Branch.." + this.Branch);
            Console.WriteLine("Marks.." + this.Marks);
            Console.WriteLine("Student Details are Displayed....");
        }
    }
}
