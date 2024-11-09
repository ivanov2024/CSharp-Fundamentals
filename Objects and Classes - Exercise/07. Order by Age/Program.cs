namespace Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int id = int.Parse(tokens[1]);
                int age = int.Parse(tokens[2]);
                People person = new People(name,id,age);

                if (people.Any(i => i.Id == id))
                {
                    person.Name = name;
                    person.Age = age;
                }
                else
                {
                    people.Add(person);
                }
            }

            List<People> orderedList = people.OrderBy(i => i.Age).ToList();
            foreach (var person in orderedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public People (string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
    }
}