namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char first = (char)('a' + i);
                for (int m = 0; m < n; m++)
                {
                    char second = (char)('a' + m);
                    for (int j = 0; j < n; j++)
                    {
                        char third = (char)('a' + j);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}