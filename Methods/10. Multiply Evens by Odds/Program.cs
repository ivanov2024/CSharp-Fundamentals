namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = 0;
            int oddSum = 0;

           Console.WriteLine(GetMultipleOfEvenAndOdds(oddSum, evenSum, number));
        
        }

        static int GetSumOfEvenDigits(int evenSum, int number)
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                if (lastDigit%2==0)
                {
                    evenSum+= lastDigit;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int oddSum, int number)
        {
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int oddSum, int evenSum, int number)
        {
            int sum = GetSumOfEvenDigits(evenSum, number) * GetSumOfOddDigits(oddSum,number);
            return sum;
        }
    }
}