namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                char orriginal = text[i];
                encryptedText += (char)(orriginal + 3);
            }

            Console.WriteLine(encryptedText);
        }
    }
}