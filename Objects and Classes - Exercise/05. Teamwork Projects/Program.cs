using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    public string Name { get; }
    public string Creator { get; }
    public List<string> Members { get; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string> { creator };
    }

    public void AddMember(string member)
    {
        Members.Add(member);
    }

    public override string ToString()
    {
        string result = $"{Name}\n- {Creator}";

        foreach (var member in Members.OrderBy(m => m))
        {
            if (member != Creator)
            {
                result += $"\n-- {member}";
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int teamCount = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();

        for (int i = 0; i < teamCount; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string user = input[0];
            string teamName = input[1];

            Team existingTeam = teams.FirstOrDefault(t => t.Name == teamName);
            if (existingTeam == null)
            {
                Team newTeam = new Team(teamName, user);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
            else
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] input = command.Split("->");
            string user = input[0];
            string teamName = input[1];

            Team existingTeam = teams.FirstOrDefault(t => t.Name == teamName);
            if (existingTeam == null)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else
            {
                if (teams.Any(t => t.Creator == user) || teams.Any(t => t.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    existingTeam.AddMember(user);
                }
            }
        }

        foreach (var team in teams.Where(t => t.Members.Count > 1).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
        {
            Console.WriteLine(team);
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teams.Where(t => t.Members.Count == 1).OrderBy(t => t.Name))
        {
            Console.WriteLine(team.Name);
        }
    }
}
