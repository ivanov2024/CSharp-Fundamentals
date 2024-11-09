using System.Xml.Linq;

namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] command;
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                command = Console.ReadLine().Split();
                string guest = command[0];

                if (command[1]  == "is" && command[2] == "not")
                {
                    if (!result.Contains(guest))
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                    else
                    {
                        result.Remove(guest);
                    }
                }
                else
                {
                    if (result.Contains(guest))
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                    else
                    {
                        result.Add(guest);
                    }
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}