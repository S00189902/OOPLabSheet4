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

            Display(teams);

            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Lose);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Lose);

            Display(teams);

            teams.Sort();

            Display(teams);

            teams.Reverse();
            Display(teams);

            SligoRovers.Players.Add(new Player() { Name = "John Smith", Position = "Goalie" });
            SligoRovers.Players.Add(new Player() { Name = "Jordan McGrath", Position = "Defender" });

            Console.WriteLine("\n Sligo Rovers Teamsheet");

            foreach(Player player in SligoRovers.Players)
            {
                Console.WriteLine("{0,-17}{1,-8}", player.Name, player.Position);
            }


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
