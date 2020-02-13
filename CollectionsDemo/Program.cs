using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            dynamic x;
            x = 67;
            x = "abc";
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add("Virat");
            al.Add(2.33);
            al.Add('m');
            al.Remove(2.33);    
            foreach(var val in al)
            {
                Console.WriteLine(val);
            }
            Queue q = new Queue();
            q.Enqueue(5);
            q.Enqueue(3);
            q.Enqueue("adca");
            q.Dequeue();
            foreach(var v in q)
            {
                Console.WriteLine(v);
            }
            Stack st = new Stack();
            st.Push(2);
            st.Push("adad");
            st.Push("3535.7");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            foreach(var s in st)
            {
                Console.WriteLine(s);
            }
            Hashtable ht = new Hashtable();
            ht.Add(1, "cts");
            ht.Add('a', 1000);
            ht.Add("t1", 30);
            foreach(var val in ht.Keys)                             
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);
            }
            List<int> li = new List<int>();
            li.Add(23);
            li.Add('a');
            li.Add(234);
            foreach(var v in li)
            {
                Console.WriteLine(v);
            }
            Stack<float> st1 = new Stack<float>();
            st1.Push(2.56f);
            st1.Push(746.6f);
            st1.Push(3535.7f);
            Console.WriteLine(st1.Pop());
            Console.WriteLine(st1.Peek());
            foreach (var s in st1)
            {
                Console.WriteLine(s);
            }
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1,"vyj");
            dt.Add(2, "fwas");
            dt.Add(3, "efwf");
            foreach (KeyValuePair<int,string> k1 in dt)
            {
                Console.WriteLine(k1.Key);
                Console.WriteLine(k1.Value);
            }
            Console.ReadKey();
        }
    }

}
