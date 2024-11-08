namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && 2 >= n)
            {
                Console.WriteLine("baby");
            }
            else if (n >= 3 && 13 >= n)
            {
                Console.WriteLine("child");
            }
            else if (n >= 14 && 19 >= n)
            {
                Console.WriteLine("teenager");
            }
            else if (n >= 20 && 65 >= n)
            {
                Console.WriteLine("adult");
            }
            else if (n >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}