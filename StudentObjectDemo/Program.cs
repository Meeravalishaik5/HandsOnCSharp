using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rollno...");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class...");
            string clas = Console.ReadLine();
            Console.WriteLine("Enter Semester...");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch...");
            string branch = Console.ReadLine();
            int[] marks = new int[5];
            Console.WriteLine("Enter Marks...");
            for(int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            Student s = new Student(rollno,name,clas,sem,branch);
            s.displayResult(marks);
            s.DisplayData(marks);
            Console.ReadKey();
        }
    }
}
