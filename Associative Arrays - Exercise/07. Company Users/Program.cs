using System.Diagnostics;

namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");
                string company = tokens[0];
                string id = tokens[1];

                if (employees.ContainsKey(company))
                {
                    if(!employees[company].Contains(id))
                    {
                        employees[company].Add(id);
                    }
                }
                else
                {
                    employees.Add(company, new List<string> { id });
                }
            }

            foreach (var user in employees)
            {
                List<string> users = user.Value;
                Console.WriteLine($"{user.Key}");

                foreach (string employee in users)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}