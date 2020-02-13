using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Employee
    {
        int salary;
        string name, empid;
        public Employee(string n,string id,int sal)
        {
            this.empid = id;
            this.name = n;
            this.salary = sal;
        }
    }
}
