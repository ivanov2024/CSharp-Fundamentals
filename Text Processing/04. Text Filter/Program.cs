namespace Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            //It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality.Therefore we owe it to them by calling the OS GNU / Linux! Sincerely, a Windows client

            foreach (string bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}