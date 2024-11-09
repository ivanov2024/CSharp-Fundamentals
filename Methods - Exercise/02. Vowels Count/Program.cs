namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split(" ");
            Console.WriteLine(VowelsCount(stringArray));
        }

        static int VowelsCount(string[] stringArray)
        {
            int vowelsSum = 0;
            string letter = string.Concat(stringArray);
            char[] charArray = letter.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'a' || charArray[i] == 'u' || charArray[i] == 'o' || charArray[i] == 'y' || charArray[i] == 'e' || charArray[i] == 'i' || charArray[i] == 'A' || charArray[i] == 'U' || charArray[i] == 'O' || charArray[i] == 'Y' || charArray[i] == 'E' || charArray[i] == 'I')
                {
                    vowelsSum++;
                }
            }
            return vowelsSum;
        }
    }
}