using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] data = input.Split(" : ");
            string courseName = data[0];
            string studentName = data[1];

            if (courses.ContainsKey(courseName))
            {
                courses[courseName].Add(studentName);
            }
            else
            {
                courses[courseName] = new List<string> { studentName };
            }
        }

        foreach (var course in courses)
        {
            List<string> registeredStudents = course.Value;
            Console.WriteLine($"{course.Key}: {registeredStudents.Count}");

            foreach (string studentName in registeredStudents)
            {
                Console.WriteLine($"-- {studentName}");
            }
        }
    }
}
