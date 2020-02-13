using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("sam", "468", 7898));
            elist.Add(new Employee("kaj", "653", 12055));
            elist.Add(new Employee("tam", "898", 7898));
            elist.Add(new Employee("alia", "875", 10523));
            List<Employee> high = elist.FindAll(e=>e.salary>10000);
            foreach(Employee e in high)
            {
                Console.WriteLine(e.ToString());
            }*/
            string name;
            int id, pid,n;
            Console.WriteLine("Enter No of Trinees...");
            n = int.Parse(Console.ReadLine());
            List<Employee> elist = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Trainee Id...");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name...");
                name = Console.ReadLine();
                Console.WriteLine("Enter Trainee ProjectId...");
                pid = int.Parse(Console.ReadLine());
                elist.Add(new Employee(id,name,pid));
            }
            
            //elist.Add(new Employee(5, "sam", 7));
            //elist.Add(new Employee(6, "riya", -1));
            //elist.Add(new Employee(8, "rose", 9));
            //elist.Add(new Employee(9, "ram", -1));
            List<Employee> tr = elist.FindAll(e => e.Pid != -1);
            foreach(Employee e in tr)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
