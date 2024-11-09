namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                  .Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commands = command.Split();

                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);

                    for(int i = 0; i < list.Count;i++)
                    {
                        if (list[i] == element)
                        {
                            list.Remove(list[i]);
                        }
                    }
                }
                else
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);

                    list.Insert(position, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}