using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Student s = new Student();
            Student s1 = new Student("raj", 120, "CSE", 2, 56);
            Console.WriteLine("Enter Student rollno...");
            s.Rollno=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name...");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter Student Semester...");
            s.Sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Branch...");
             s.Branch = Console.ReadLine();
            Console.WriteLine("Enter Student Marks...");
            s.Marks = int.Parse(Console.ReadLine());
            s.AcceptStudentDetails();
            s.DisplayStudentDetails();
           
            Console.ReadKey();
        }
    }
}
