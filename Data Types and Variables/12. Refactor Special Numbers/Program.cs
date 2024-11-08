namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
            bool magicN = false;
            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                magicN = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, magicN);
                sum = 0;
                i = currentNumber;
            }
        }
    }
}