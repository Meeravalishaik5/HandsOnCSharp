using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dt = new Dictionary<string,int>();
            Console.WriteLine("Enter NO of Employees..");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Employee name...");
                string s = Console.ReadLine();
                Console.WriteLine("Enter Employee salary...");
                int sal = int.Parse(Console.ReadLine());
                dt.Add(s, sal);
            }
            Console.WriteLine("Employees Details are...");
            foreach (KeyValuePair<string,int> k1 in dt)
            {
                Console.WriteLine(k1.Key);
                Console.WriteLine(k1.Value);
            }
            int max = 0;
            string s1=null;
            foreach (KeyValuePair<string, int> k1 in dt)
            {
                if (k1.Value > max)
                {
                    max = k1.Value;
                    s1= k1.Key;
                }
            }
            Console.WriteLine("The Employee name getting highest Salary..."+s1);
            Console.WriteLine("highest Salary is..."+max);
            Console.ReadKey();
        }
    }
}
