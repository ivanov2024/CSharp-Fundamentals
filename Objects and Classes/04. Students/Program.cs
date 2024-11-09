namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string information;

            string firstName;
            string lastName;
            string age;
            string city;

            while ((information = Console.ReadLine())
                != "end")
            {
                string[] arr = information.Split();

                firstName = arr[0];
                lastName = arr[1];
                age = arr[2];
                city = arr[3];

                Student students = new Student(firstName, lastName, age, city);

                list.Add(students);
            }

            string cityFilter = Console.ReadLine();

            foreach (Student student in list)
            {
                if (student.City == cityFilter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public Student(string firstName, string lastName, string age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
    }
}