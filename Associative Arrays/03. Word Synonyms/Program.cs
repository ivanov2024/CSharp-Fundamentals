namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
           int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word,new List<string>());
                }
                    words[word].Add(synonym);
            }

            foreach (var kvp in words)
            {
                string word = kvp.Key;
                List<string> synonymList = kvp.Value;
                string synonymsAsString = string.Join(", ", synonymList);

                Console.WriteLine($"{word} - {synonymsAsString}");
            }
        }
    }
}