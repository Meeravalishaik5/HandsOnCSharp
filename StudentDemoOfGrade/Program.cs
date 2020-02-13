using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemoOfGrade
{
    interface IStudent
    {
        int sid { get; set; }
        string name { get; set; }
        void showDetails(String name,int sid);
    }
    class Resident : IStudent
    {
        int Sid; string Name;
        int IStudent.sid { get { return Sid; } set { Sid = value; } }
        string IStudent.name { get { return Name; } set { Name = value; } }
        public void showDetails(string Name,int Sid)
        {
            Console.WriteLine(Sid + " " + Name);
        }
    }
    class Dayscholar : IStudent
    {
        int Sid; string Name;
        int IStudent.sid { get { return Sid; } set { Sid = value; } }
        string IStudent.name { get { return Name; } set { Name = value; } }
        public void showDetails(string Name,int Sid)
        {
            Console.WriteLine(Sid + " " + Name);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Student s;
            s = new Undergraduate();
           bool s1= s.IsPassed(70.0);
            Console.WriteLine(s1);
            s = new Graduate();
            bool s2=s.IsPassed(83.0);
            Console.WriteLine(s2);
            Console.ReadKey();*/
            IStudent s2;
            s2 = new Resident();
            s2.showDetails(" gfdg",66);
            s2 = new Dayscholar();
            s2.showDetails(" grgr", 77);
            Console.ReadKey();
            
        }
    }
}
