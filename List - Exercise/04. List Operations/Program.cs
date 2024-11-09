using System;
using System.Reflection;

namespace List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split();
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int item = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index < 0 || index >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        list.Insert(index, item);
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < 0 ||
                            int.Parse(command[1]) >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        list.RemoveAt(int.Parse(command[1]));

                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        count %= list.Count;

                        if (command[1] == "left")
                        {
                            List<int> cutPart = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, cutPart);
                        }
                        else if (command[1] == "right")
                        {
                            List<int> cutPart = list.GetRange(
                              list.Count - count, count);
                            list.RemoveRange(list.Count - count, count);
                            list.InsertRange(0, cutPart);
                        }
                        break;
                }

            }
                Console.WriteLine(string.Join(" ", list));
        }
    }     
}