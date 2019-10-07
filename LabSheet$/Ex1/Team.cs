using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
   public class Team
    {
        private string teamName;

        public string TeamName
        {
            get {return this.teamName; }
           private set { this.teamName = value; }
        }

        private int numWins;

        public int NumWins
        {
            get { return numWins; }
            private set {numWins = value; }
        }

        private int numDraws;

        public int NumDraws
        {
            get { return numDraws; }
            private set { numDraws = value; }
        }

        private int numLosses;

        public int NumLosses
        {
            get { return numLosses; }
            private set { numLosses = value; }
        }

        private int numGames;

        public int NumGames
        {
            get { return numGames; }
            private set { numGames = value; }
        }

        private int points;

        public int Points
        {
            get
            {
                points = (NumWins * 3) + (NumDraws * 1);
                return points;
            }

        }

        public Team(string name)
        {
            TeamName = name;
        }

        public string DisplayTable()
        {
            return string.Format($"{TeamName,-15}{Points,-7}{NumDraws,-7}{NumLosses,-7}{NumGames,-7}");
        }


       






    }
}
