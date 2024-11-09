namespace Exercise_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            32 54 21 12 4 0 23 
            75
            Add 10
            Add 0
            30
            10
            75
            end
             */

            List<int> list = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            
            int maxCapacity = int.Parse(Console.ReadLine());
            List<int> result = new List<int>(list);

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "Add")
                {
                    result.Add(int.Parse(arguments[1])); continue;
                }

                int passengers = int.Parse(arguments[0]);
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] + passengers <= maxCapacity)
                    {
                        result[i] += passengers;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}