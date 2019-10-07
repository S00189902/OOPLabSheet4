using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");

            teams.Add(SligoRovers);
            teams.Add(FinnHarps);
            teams.Add(GalwayUnited);
            teams.Add(DerryCity);
            teams.Add(Dundalk);

            
        }
        static void Display(List<Team> teams)
        {
            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach(Team team in teams)
            {
                Console.WriteLine(team.DisplayTable());
            }
        }
    }
}
