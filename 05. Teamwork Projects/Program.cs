using static _05._Teamwork_Projects.Program;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                List<string> teamInformation = Console.ReadLine()
                    .Split("-")
                    .ToList();
                string teamName = teamInformation[1];
                string creatorName = teamInformation[0];

                if (IsCreated(creatorName, teamName, teams))
                {
                    Team team = new Team(creatorName, teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }
            string input = "";
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                List<string> assignment = input
                        .Split("->")
                        .ToList();
                string memberName = assignment[0];
                string teamName = assignment[1];
                bool teamExist = false;
                foreach (Team team in teams)
                {
                    if (team.TeamName == teamName)
                    {
                        teamExist = true;
                        if (teams.Any(x => x.Members.Contains(memberName) || teams.Any(x => x.Creator == memberName)))
                        {
                            Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                            break;
                        }
                        else
                        {
                            team.Members.Insert(team.Members.Count, memberName);
                            break;
                        }
                    }
                }
                if (!teamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }
            foreach (Team team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {

                if (team.Members.Count > 1)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.Creator}");
                    for (int i = 1; i < team.Members.Count; i++)
                    {
                        Console.WriteLine($"-- {team.Members[i]}");
                    }

                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                if (team.Members.Count <= 1)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
        static bool IsCreated(string creator, string teamName, List<Team> teams)
        {
            bool created = true;
            foreach (Team team in teams)
            {
                if (teams.Any(x => x.TeamName == teamName))
                {
                    created = false;
                    Console.WriteLine($"Team {teamName} was already created!");
                    return created;

                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    created = false;
                    Console.WriteLine($"{creator} cannot create another team!");
                    return created;
                }
            }
            return created;

        }
        public class Team
        {
            public Team(string creator, string teamName, string members)
            {
                Creator = creator;
                TeamName = teamName;
                Members = members.Split().ToList();
            }
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> Members { get; set; }
        }

    }
}