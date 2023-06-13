using System.Text.Json;
using HomeworkDotNetBasicThree.Models;

namespace HomeworkDotNetBasicThree
{
    class Linq
    {
        public void ProcessData()
        {
            List<Team> teams = ReadTeamsFromFile("teams.txt");
            PerformLinqQueries(teams);
            WriteTeamsToJson(teams, "output.json");
        }

        private List<Team> ReadTeamsFromFile(string filePath)
        {
            List<Team> teams = new List<Team>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3)
                    {
                        Team team = new Team
                        {
                            Name = parts[0],
                            Country = parts[1],
                            EstablishedYear = int.Parse(parts[2])
                        };
                        teams.Add(team);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return teams;
        }

        private void PerformLinqQueries(List<Team> teams)
        {
            var filteredTeams = teams.Where(team => team.EstablishedYear > 2000);
            var firstTeam = teams.FirstOrDefault(team => team.Name.StartsWith("Mercedes"));
            bool anyTeam = teams.Any(team => team.Country == "Italy");
            var distinctCountries = teams.Select(team => team.Country).Distinct();
            var groupedByCountry = teams.GroupBy(team => team.Country);
            var orderedTeams = teams.OrderByDescending(team => team.EstablishedYear);
            var selectedTeams = teams.Select(team => new { team.Name, team.Country });

            // Print or further process the query results if needed
            Console.WriteLine("Filtered Teams:");
            foreach (var team in filteredTeams)
            {
                Console.WriteLine($"Name: {team.Name}, Country: {team.Country}, Established Year: {team.EstablishedYear}");
            }
        }

        private void WriteTeamsToJson(List<Team> teams, string filePath)
        {
            string json = JsonSerializer.Serialize(teams, new JsonSerializerOptions { WriteIndented = true });

            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
