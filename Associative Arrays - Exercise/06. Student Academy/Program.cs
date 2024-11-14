using System.ComponentModel;
using System.Xml.Linq;

namespace Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(student))
                {
                    students[student].Add(grade);
                }
                else
                {
                    List<double> list = new List<double>();
                    list.Add(grade);
                    students.Add(student, list);
                }
            }

            foreach (var student in students)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}