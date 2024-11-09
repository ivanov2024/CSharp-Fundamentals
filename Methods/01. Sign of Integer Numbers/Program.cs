namespace Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Sign(n);
        }

        static void Sign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive. ");
            }
            
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative. ");
            }

            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero. ");
            }
        
        }
    }
}