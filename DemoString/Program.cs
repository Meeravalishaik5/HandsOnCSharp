using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome";
            Console.WriteLine(str.Length + " " + str.Replace("e", "k") + " " + str.ToLower());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(string.Compare("hello", "HELLO"));
            Employee[] e = new Employee[3] { new Employee("Ram", "459", 45000), new Employee("tej", "45", 45000), new Employee("Raj", "450", 45000) };
           Employee[] elist=new Employee[3];
            List<Employee> el = new List<Employee>();
            el.Add(new Employee("Ram", "300",20000));
            el.Add(new Employee("JAy", "300",20000));
            el.Add(new Employee("Rahul", "300",20000));

        }
    }
}
