﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = new Singleton();
            s1.printDetails("Hello");
            Singleton s2 = new Singleton();
            s2.printDetails("How are you..");
            Console.ReadKey();
        }
    }
}
