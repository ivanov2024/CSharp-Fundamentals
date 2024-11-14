namespace A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                long quantities = long.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                {
                    resources[input] += quantities;
                }
                else
                {
                    resources.Add(input, quantities);
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}