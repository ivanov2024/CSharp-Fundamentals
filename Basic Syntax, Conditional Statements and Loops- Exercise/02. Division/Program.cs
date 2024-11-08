namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //if (n % 2 == 0 && n % 10 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 10");
            //}
            //else if (n % 2 == 0 && n % 3 == 0 && n % 6 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 6");
            //}
            //else if (n % 6 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 6");
            //}
            //else if (n % 3 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 3");
            //}
            //else if (n % 2 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 2");
            //}
            //else
            //{
            //    Console.WriteLine("Not divisible");
            //}

            int number = int.Parse(Console.ReadLine());
            string division = number % 10 == 0 ? "The number is divisible by 10" : number % 7 == 0 ? "The number is divisible by 7" : number % 6 == 0 ? "The number is divisible by 6" : number % 3 == 0 ? "The number is divisible by 3" : number % 2 == 0 ? "The number is divisible by 2" : "Not divisible";

            Console.WriteLine(division);
        }
    }
}