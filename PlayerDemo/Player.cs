using System;

namespace PlayerDemo
{
    abstract class Player
    {
        protected string name;
        protected string tname;
        protected int noofMatches;
        /*public Player(string n,string tn,int m)
          {
              this.name = n;
              this.tname = tn;
              this.noofMatches=m;
          }

         public virtual void DisplayPlayerStats(string na, string tn, int n1)
          {
              this.name = na;
              this.tname = tn;
              this.noofMatches = n1;
          }*/
        public abstract void DisplayPlayerStats();
    }
    class CricketPlayer : Player
    {
        int totalrunscored;
        int noofWicketstaken;
        public CricketPlayer(string n, string tn, int b,int r,int w)
        {
            this.name = n;
            this.tname = tn;
            this.noofMatches = b;
            this.totalrunscored = r;
            this.noofWicketstaken = w;
        }
        public override void DisplayPlayerStats()
        {
            Console.WriteLine("Cricket Player Details..." + "\nName..." + this.name + "\nTeam name..." + this.tname + "\nNo of Matches.." + this.noofMatches + "\n Runs.." + this.totalrunscored + "\nWickets..." + this.noofWicketstaken);
            //throw new NotImplementedException();
        }
    }
    class HockeyPlayer : Player
    {
        string position;
        int noofGoals;
        public HockeyPlayer(string n, string tn, int b,string pos,int g)
        {
            this.name = n;
            this.tname = tn;
            this.noofMatches = b;
            this.position = pos;
            this.noofGoals = g;
        }
        public override void DisplayPlayerStats()
        {
            Console.WriteLine("Hockey Player Details.." + "\nName..." + this.name + "\nTeam name..." + this.tname + "\nNo of Matches.." + this.noofMatches + "\nPosition.." + this.position + "\nGoals..." + this.noofGoals);
            // throw new NotImplementedException();
        }
    }

}
