using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentObjectDemo
{
    class Student
    {
        static string colgname="CTS";
        int rollno;
        string name;
        string clas;
        int sem;
        string branch; 
        public Student(int rollno,string name,string clas,int sem,string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.clas = clas;
            this.sem = sem;
            this.branch = branch;
        }
        public void displayResult(int[] marks)
        {
            double sum = 0,avg;
            for(int i = 0; i < marks.Length; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / marks.Length;
            int count=1;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    count = 0;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Student was Failed...");
            }
            else
            {
                if (avg > 50)
                {
                    Console.WriteLine("Student was Pass...");
                }
                else if (avg < 50)
                {
                    Console.WriteLine("Student was Failed...");
                }
            }
        }
        public void DisplayData(int[] marks)
        {
            Console.WriteLine("College Name.."+colgname+"\nStudent name.."+name+"\nRoll No.."+rollno+"\nclass is.."+clas+"\nSemester is.."+sem+"\nBranch is.."+branch);
            Console.WriteLine("Marks are...");
            foreach(int x in marks)
            {
                Console.Write(x + "\t");
            }        
        }
    }
}
