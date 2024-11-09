namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(n1,n2,n3));
        }

        static int SmallestNumber(int n1, int n2, int n3)
        {
            int a = Math.Min(n1, n2);
            int b = Math.Min(n2, n3);
            return Math.Min(a,b);
        }
    }
}