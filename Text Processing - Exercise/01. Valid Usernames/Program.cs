namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsUserNameValid(usernames[i]))
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }

        static bool IsUserNameValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            foreach (char c in username)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_' && c != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}