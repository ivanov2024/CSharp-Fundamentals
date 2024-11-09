namespace List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> List_of_Strings = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                List_of_Strings.Add(product);
            }

            List_of_Strings.Sort();

            for (int i = 0; i < List_of_Strings.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{List_of_Strings[i]}");
            }
        }
    }
}