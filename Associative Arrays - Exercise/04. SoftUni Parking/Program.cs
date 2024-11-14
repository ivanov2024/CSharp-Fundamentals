namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string username = command[1];

                if (command[0] == "register")
                {
                    string licensePlateNumber = command[2];

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else
                {
                    if (users.ContainsKey(username) == false)
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        users.Remove(username);
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}