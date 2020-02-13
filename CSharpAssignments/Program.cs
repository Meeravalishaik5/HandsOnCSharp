using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Program
    {
        /*  public static void Hello()
          {
              Console.WriteLine("Welcome To The World Of C#");
          }
          public static void Welcome()
          {
              Console.WriteLine("ENTER USERNAME : ");
              String s = Console.ReadLine();
              Console.WriteLine("HI! " + s + " Welcome to the world of C#");
          }
          public static void BetweenTwoNos()
          {
              Console.WriteLine("ENTER FIRST NO...");
              int i = int.Parse(Console.ReadLine());
              Console.WriteLine("ENTER SECOND NO...");
              int j = int.Parse(Console.ReadLine());
              for(int k=i;k<=j;k++)
              {
                  Console.Write(k + "\t");
              }
          }
          public static void EvenorOdd()
          {
              Console.WriteLine("ENTER ANY NO...");
              int i = int.Parse(Console.ReadLine());
              if (i % 2 == 0)
              {
                  Console.WriteLine("The No Is Even
                  ...");
              }
              else
              {
                  Console.WriteLine("The No Is Odd");
              }
          }
          public static void CountEvenandOdd()
          {
              int i, count=0, count1=0;
              int[] a = new int[100];
              Console.WriteLine("Enter the size of array..");
              int n = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter the Elements..");
              for (i = 0; i < n; i++)
              {
                  a[i] = int.Parse(Console.ReadLine());
              }
              for(i=0;i<n;i++)
              {
                  if(a[i]%2==0)
                  {
                      count++;
                  }
                  else
                  {
                      count1++;
                  }
              }
              Console.WriteLine("Total No Of Even No's..."+count);
              Console.WriteLine("Total No of Odd No's..."+count1);

          }
          public static void Temperature()
          {
              Console.WriteLine("Enter the Temperature In Faranhiet...");
              double f = double.Parse(Console.ReadLine());
              double c = f - 32;
              double d = c * 5/9;
              Console.WriteLine("Temperature In Celcius.."+d);
          }
          public static void Squares()
          {
              for(int i=0;i<=25;i++)
              {
                  Console.Write(i * i + "\t");
              }
          }
          public static void fact(int n)
          {
              int i, f = 1;
              for(i=1;i<=n;i++)
              {
                  f = f * i;
              }
              Console.WriteLine("Factorial of a "+n+" is "+f);
          }
          public static void Fibanocci(int n)
          {
              int a = 0, b = 1,c;
              for (int i=0;i<n;i++)
              {
                  if (i <= 1)
                      c = i;
                  else
                  {
                      c = a + b;
                      a = b;
                      b = c;
                  }

                 Console.Write(c+"\t");
              }
          }
          public static void Multi()
          {
              Console.WriteLine("Enter Table No...");
              int n = int.Parse(Console.ReadLine());
              for(int i=1;i<=20;i++)
              {
                  Console.WriteLine(n + "*" + i + "=" + n * i);
              }
          }
          public static void Divisibleby()
          {
              for(int i=200;i<=300;i++)
              {
                  if(i%7==0)
                  {
                      Console.WriteLine(i + "\t");        
                  }
              }
          }
          public static void Max()
          {
              Console.WriteLine("Enter First Number...");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Second Number...");
              int b = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Third Number...");
              int c = int.Parse(Console.ReadLine());
              if(a>b && a>c)
              { 
                    Console.WriteLine("Max is..." + a);
              }
              else if(b>a && b > c)
              {
                  Console.WriteLine("Max is..." + b);
              }
              else
              {
                  Console.WriteLine("Max is..." + c);
              }
          }
          public static void Smallest()
          {
              int[] a = new int[100];
              int small,i;
              Console.WriteLine("Enter the size of array..");
              int n = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter the Elements..");
              for (i = 0; i < n; i++)
              {
                  a[i] = int.Parse(Console.ReadLine());
              }
              small = a[0];
              for(i=0;i<n;i++)
              {
                  if (a[i] < small)
                      small = a[i];
              }
              Console.WriteLine("Smallest Number is..."+small);
          }
        public static void ResultOf()
        {
            int[] a = new int[100];
            int i, total = 0, small, max, temp, j;
            double avg;
            Console.WriteLine("Enter the total no of Subjects..");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Subject Marks..");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                total = total + a[i];
            }
            Console.WriteLine("Total is.." + total);
            avg = total / n;
            Console.WriteLine("Average is.." + avg);
            small = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] < small)
                    small = a[i];
            }
            Console.WriteLine("Minimum Marks are..." + small);
            max = a[0];
            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("Maximum Marks are ..." + max);
            Console.WriteLine("Marks in Ascending Order...");
            for (i = 0; i < n; i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if (a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(i=0;i<n;i++)
            {
                Console.WriteLine(a[i] + "\t");
            }
            Console.WriteLine("Marks in Descending Order...");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[j] > a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + "\t");
            }

        }
        public static void LenOfWord()
        {
            Console.WriteLine("Enter a Word...");
            string s = Console.ReadLine();
            Console.WriteLine("The Length of a string is.."+s.Length);
        }
        public static void CompOfWord()
        {
            Console.WriteLine("Enter a Word...");
            string s = Console.ReadLine();
            Console.WriteLine("Enter a Word...");
            string s1 = Console.ReadLine();
            if(s.Equals(s1))
            {
                Console.WriteLine("Same...");
            }
            else
            {
                Console.WriteLine("Not Same...");
            }
        }
        public static void RevOfWord()
        {
            Console.WriteLine("Enter a Word...");
            string s = Console.ReadLine();
           
        }*/

       static void Main(string[] args)
        {
            /* Console.WriteLine("HELLO WORLD PROGRAM..");
             Hello();
             Console.WriteLine("ACCEPTING INPUT FROM USER..");
             Welcome();
             Console.WriteLine("DISPLAYING ALL NO'S BETWEEN TWO NO'S..");
             BetweenTwoNos();
             Console.WriteLine("CHECKING WHETHER A NO IS EVEN OR ODD..");
             EvenorOdd();
            Console.WriteLine("Counting the Odd And Even No's...");
            CountEvenandOdd();
            Console.WriteLine("Enter Temperature in Faranheit And Print In Celcius...");
            Temperature();
            Console.WriteLine("Printing The Series...");
            Squares();
            Console.WriteLine("Factorial of a Number..");
            Console.WriteLine("Enter a Number..");
            int f = int.Parse(Console.ReadLine());
            fact(f);
            Console.WriteLine("Fibanocci Series...");
            Fibanocci(40);
            Console.WriteLine("Multiplication Table...");
            Multi();
            Console.WriteLine("Divisible by 7 between 200 and 300...");
            Divisibleby();
            Console.WriteLine("Largest of Three Numbers...");
            Max();
            Console.WriteLine("Smallest of Five Numbers...");
            Smallest();
            Console.WriteLine("Student Marks...");
            ResultOf();
            Console.WriteLine("Length of a Word...");
            LenOfWord();
            Console.WriteLine("Comparing of two Words...");
            CompOfWord();
            Console.WriteLine("Reversing a Word...");
            RevOfWord();*/
            Console.ReadKey();
        }
    }
}
