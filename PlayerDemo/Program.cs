using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter Player Name...");
             string n = Console.ReadLine();
             Console.WriteLine("Enter Team Name...");
             string tn = Console.ReadLine();
             Console.WriteLine("Enter No of Matches Played...");
             int m = int.Parse(Console.ReadLine());*/
            Console.WriteLine("1.Enter 1 To View Cricket Player Details...\n2.Enter 2 to view Hockey Player Details...\n3.Enter 3 to exit...");
            for(; ; )
            {
                Console.WriteLine("Enter Choice...");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1 :
                            Player p = new CricketPlayer("Ash", "CSK", 3, 125, 5);
                            p.DisplayPlayerStats();
                            break;
                    case 2 :
                             Player h = new HockeyPlayer("RAM", "DD", 6, "Right Corner", 4);
                             h.DisplayPlayerStats();
                             break;
                    case 3 : return;
                    default :Console.WriteLine("Invalid choice...");
                        break;
                }

            }
            /*if (ch == 1)
            {
                Player p = new CricketPlayer("Ash", "CSK", 3,125,5);
                p.DisplayPlayerStats();
            }
            else if (ch == 2)
            {
                Player h = new HockeyPlayer("RAM", "DD", 6,"Right Corner",4);
                h.DisplayPlayerStats();
            }  */          
           // Console.ReadKey();
        }
    }
}
