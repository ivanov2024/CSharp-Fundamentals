using System;

namespace MultiplyingBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string digit = Console.ReadLine();
            char[] result = new char[bigNumber.Length + 1];

            int carry = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(bigNumber[i].ToString());
                int multiplier = int.Parse(digit);
                int product = multiplier * number + carry;

                result[i + 1] = (char)((product % 10) + '0');
                carry = product / 10;
            }

            result[0] = (char)(carry + '0');

            string resultString = new string(result);
            resultString = resultString.TrimStart('0');
            if (string.IsNullOrEmpty(resultString))
            {
                resultString = "0";
            }

            Console.WriteLine(resultString);
        }
    }
}
