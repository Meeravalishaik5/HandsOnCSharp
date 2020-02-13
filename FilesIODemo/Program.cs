using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\\mydir");
            if(di.Exists==false)
                di.Create();//To Create a Directory if it won't Exists
           // di.CreateSubdirectory("hFG");To Create A Subdirectory...
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo de in d)
            {
                Console.WriteLine(de.Name+" "+de.FullName+" "+de.CreationTime);
            }
            FileInfo[] f = di.GetFiles();
            Console.WriteLine("........");
            foreach(FileInfo f1 in f)
            {
                Console.WriteLine(f1.Name+" "+f1.FullName+" "+f1.CreationTime);
            }
            /*FileStream fs = new FileStream(@"E:\\webid.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome");
            sw.Close();
            fs.Close();*/
            FileStream fs1 = new FileStream(@"E:\\web.txt", FileMode.OpenOrCreate, FileAccess.Write);
            /*StreamReader sr = new StreamReader(fs1);
            string s;
            while ((s=sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();*/
            BinaryWriter bw = new BinaryWriter(fs1);
            int i = 10;
            char ch = 'd';
            string s = "hello";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(s);
            bw.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(@"E:\\web.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs2);
            int x = br.ReadInt32();
            char c = br.ReadChar();
            string se = br.ReadString();
            Console.WriteLine(x + " " + c + " " + " " + se);
            br.Close();
            fs2.Close();
            Console.ReadKey();
        }
    }
}
