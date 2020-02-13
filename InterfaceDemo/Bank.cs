using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ILoan
    {
        void getIntrest();
    }
    interface IGLoan : ILoan 
    {
        void getGintrest();
    }
    public abstract class Bank
    {

        protected string bName;
        protected string Location;
        public Bank(string bname,string location)
        {
            this.bName = bname;
            this.Location = location;
        }
    }
    public class SBI : Bank,ILoan
    {
        string bManager;
        public SBI(string bname,string loc,String bmgr):base(bname,loc)
        {
            this.bManager = bmgr;
        }
        public void getIntrest()
        {
            Console.WriteLine("Sbi loan intrest rate is 12%");
        }
        public void getGIntrest()
        {
            Console.WriteLine("Sbi Gold loan intrest rate is 8%");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("bank name.."+this.bName+"\nLocation.."+this.Location+"\nManager.."+this.bManager);
        }
    }
    public class ICICI : Bank,ILoan
    {
        string bManager;
        public ICICI(string bname, string loc, String bmgr):base(bname,loc)
        {
            this.bManager = bmgr;
            this.bName = bname;
            this.Location = loc;
        }
        public void getGIntrest()
        {
            Console.WriteLine("Icici Gold loan intrest rate is 9%");
        }
        public void getIntrest()
        {
            Console.WriteLine("Icici loan intrest rate is 17%");
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine("bank name.." + this.bName + "\nLocation.." + this.Location + "\nManager.." + this.bManager);
        }
    }
}
