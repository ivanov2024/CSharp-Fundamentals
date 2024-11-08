namespace Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int numDouble = num;
            int sum = 0;


            while (num > 0)
            {
                int fact = 1;
                int currentNum = num % 10;
                num = num / 10;
                for (int i = 2; i <= currentNum; i++)
                {
                    fact *= i;
                }
                sum += fact;


            }

            if (sum == numDouble)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}