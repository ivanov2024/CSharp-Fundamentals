namespace Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input;
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split()
                    .ToList();

                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);
                Students student = new Students(firstName, secondName, grade);
                students.Add(student);
            }

            List<Students> orderedList = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Students studen in orderedList)
            {
                Console.WriteLine($"{studen.FirstName} {studen.SecondName}: {studen.Grade:f2}");
            }
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            SecondName = lastName;
            Grade = grade;
        }
    }
}