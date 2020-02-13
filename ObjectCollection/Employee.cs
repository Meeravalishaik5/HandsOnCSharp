using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDemo
{
    public class Employee
    {
        int trineeId;
        string tname;
        int pid;
        public int Pid { get => pid; set => pid = value; }

        public Employee()
        {

        }
        public Employee(int tid,string na,int pid)
        {
            this.trineeId = tid;
            this.tname = na;
            this.Pid = pid;
        }
        public override string ToString()
        {
            return this.trineeId+" "+this.tname+" "+this.Pid;
        }
    }

}
