using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDemo
{
    class Employee
    {
        int eid;
        string eName, EDesignation;
        public string ename { get => eName; set => eName = value; }

        public  string eDesignation { get => EDesignation; set => EDesignation = value; }

        public int Eid { get => eid; set => eid = value; }

        public Employee()
        {

        }
        public Employee(int eid,string ename,string des)
        {
            this.Eid = eid;
            this.ename = ename;
            this.eDesignation = des;
        }
        public override string ToString()
        {
            return " Employee Id.."+this.Eid + "\tEmployee name " + this.ename + "\tEmployee Designation... " + this.eDesignation;
        }
    }
}
