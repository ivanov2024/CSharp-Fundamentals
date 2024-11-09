namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Printing(n);
        }

        static void Printing(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                 Something(i);
            }
        }

        static void Something(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}