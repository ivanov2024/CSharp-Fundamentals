
using System.Data;

internal class Program
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());
        Definition(grade);
    }

    static void Definition(double grade)
    {
        if (grade >= 2.00 && 2.99 >= grade)
        {
            Console.WriteLine("Fail");
        }
        else if (grade >= 3.00 && 3.49 >= grade)
        {
            Console.WriteLine("Poor");
        }
        else if (grade >= 3.50 && 4.49 >= grade)
        {
            Console.WriteLine("Good");
        }
        else if (grade >= 4.50 && 5.49 >= grade)
        {
            Console.WriteLine("Very good");
        }
        else if (grade >= 5.50 && 6.00 >= grade)
        {
            Console.WriteLine("Excellent");
        }
    }
}
