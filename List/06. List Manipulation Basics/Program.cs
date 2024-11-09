namespace List_Manipulation_Basics
{
    /*
     * 23 1 456 63 32 87 9 32
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine()
                .Split().ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1])); break;
                    case "Remove":
                        list.Remove(int.Parse(command[1])); break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1])); break;
                    case "Insert":
                        list.Insert(int.Parse(command[2]),
                            int.Parse(command[1])); break;

                }
                command = Console.ReadLine()
                .Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}