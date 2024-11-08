namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokedCount = 0;
            int orriginalN = n;

            while (n >= m)
            {
                n -= m;
                pokedCount++;

                if (orriginalN/2==n && y !=0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokedCount);

        }
    }
}