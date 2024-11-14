namespace Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            string input = Console.ReadLine();
            
            foreach(char c in input)
            {
                if (c != ' ')
                {
                    if (counts.ContainsKey(c))
                    {
                        counts[c]++;
                    }
                    else
                    {
                        counts.Add(c, 1);
                    }
                }
            }

            foreach (var items in counts)
            {
                Console.WriteLine($"{items.Key} -> {items.Value}");
            }
        }
    }
}