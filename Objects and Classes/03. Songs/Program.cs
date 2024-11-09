namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> list = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song(type, name, time);
                list.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in list)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in list)
                {
                    if (song.Type == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    public class Song
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string type, string name, string time)
        {
            Type = type;
            Name = name;
            Time = time;
        }
    }
}

