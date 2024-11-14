namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            for (int i = 0; i < line2.Length; i++)
            {
                int index = line2.IndexOf(line1);
                
                if (index < 0)
                {
                    break;
                }

                line2 = line2.Remove(index, line1.Length);
            }

            Console.WriteLine(line2);
        }
    }
}