namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
          Print_Matrix(n);
        }

        static void Print_Matrix(int n)
        {
            for (int column = 0; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}